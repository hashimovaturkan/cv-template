using CvTemplate.Application.Core.Extensions;
using CvTemplate.Domain.Models.DataContexts;
using CvTemplate.Domain.Models.Entities;
using MediatR;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CvTemplate.Application.Modules.Admin.AttachmentModule
{
    public class AttachmentCreateCommand : IRequest<int>
    {
        public string AttachmentUrl { get; set; }
        public string Name { get; set; }
        public string IconUrl { get; set; }
        public IFormFile AttachmentFile { get; set; }
        public IFormFile IconFile { get; set; }
        public class AttachmentCreateCommandHandler : IRequestHandler<AttachmentCreateCommand, int>
        {
            readonly CvTemplateDbContext db;
            readonly IActionContextAccessor ctx;
            readonly IWebHostEnvironment env;
            public AttachmentCreateCommandHandler(CvTemplateDbContext db, IActionContextAccessor ctx, IWebHostEnvironment env)
            {
                this.ctx = ctx;
                this.db = db;
                this.env = env;
            }
            public async Task<int> Handle(AttachmentCreateCommand request, CancellationToken cancellationToken)
            {

                if (request.AttachmentFile == null || request.IconFile == null)
                {
                    ctx.ActionContext.ModelState.AddModelError("file", "There is not file");
                }

                if (ctx.IsModelStateValid())
                {
                    var model = new Attachment();
                    model.AttachmentUrl = request.AttachmentUrl;
                    model.Name = request.Name;
                    model.IconUrl = request.IconUrl;

                    string extension1 = Path.GetExtension(request.AttachmentFile.FileName);
                    string extension2 = Path.GetExtension(request.IconFile.FileName);
                    model.AttachmentUrl = $"{Guid.NewGuid()}{extension1}";
                    model.IconUrl = $"{Guid.NewGuid()}{extension2}";

                    string physicalFileName1 = Path.Combine(env.ContentRootPath,
                                                           "wwwroot",
                                                           "uploads",
                                                           "files",
                                                           model.AttachmentUrl);

                    string physicalFileName2 = Path.Combine(env.ContentRootPath,
                                                           "wwwroot",
                                                           "uploads",
                                                           "images",
                                                           model.IconUrl);

                    using (var stream = new FileStream(physicalFileName1, FileMode.Create, FileAccess.Write))
                    {
                        await request.AttachmentFile.CopyToAsync(stream);
                    }

                    using (var stream = new FileStream(physicalFileName2, FileMode.Create, FileAccess.Write))
                    {
                        await request.IconFile.CopyToAsync(stream);
                    }

                    db.Attachments.Add(model);
                    await db.SaveChangesAsync();

                    return model.Id;
                }

                return 0;

            }
        }
    }
}
