using CvTemplate.Application.Core.Extensions;
using CvTemplate.Domain.Models.DataContexts;
using MediatR;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CvTemplate.Application.Modules.Admin.AttachmentModule
{
    public class AttachmentUpdateCommand : AttachmentViewModel, IRequest<int>
    {
        public class AttachmentUpdateCommandHandler : IRequestHandler<AttachmentUpdateCommand, int>
        {
            readonly CvTemplateDbContext db;
            readonly IActionContextAccessor ctx;
            readonly IWebHostEnvironment env;
            public AttachmentUpdateCommandHandler(CvTemplateDbContext db, IActionContextAccessor ctx, IWebHostEnvironment env)
            {
                this.env = env;
                this.ctx = ctx;
                this.db = db;
            }
            public async Task<int> Handle(AttachmentUpdateCommand request, CancellationToken cancellationToken)
            {
                if (request.Id == null || request.Id <= 0)
                    return 0;

                if (string.IsNullOrWhiteSpace(request.fileTemp1) && request.AttachmentFile == null)
                {
                    ctx.ActionContext.ModelState.AddModelError("file", "File was added!");
                }

                if (string.IsNullOrWhiteSpace(request.fileTemp2) && request.IconFile == null)
                {
                    ctx.ActionContext.ModelState.AddModelError("file", "Image was added!");
                }


                if (ctx.IsModelStateValid())
                {
                    var entity = await db.Attachments.FirstOrDefaultAsync(b => b.Id == request.Id && b.DeletedByUserId == null);

                    if (entity == null)
                    {
                        return 0;
                    }

                    entity.Name = request.Name;

                    if (request.AttachmentFile != null)
                    {
                        string extension1 = Path.GetExtension(request.AttachmentFile.FileName);
                        string extension2 = Path.GetExtension(request.IconFile.FileName);
                        request.AttachmentUrl = $"{Guid.NewGuid()}{extension1}";
                        request.IconUrl = $"{Guid.NewGuid()}{extension2}";

                        string physicalFileName1 = Path.Combine(env.ContentRootPath,
                                                               "wwwroot",
                                                               "uploads",
                                                               "files",
                                                               request.AttachmentUrl);

                        string physicalFileName2 = Path.Combine(env.ContentRootPath,
                                                               "wwwroot",
                                                               "uploads",
                                                               "images",
                                                               request.IconUrl);

                        using (var stream = new FileStream(physicalFileName1, FileMode.Create, FileAccess.Write))
                        {
                            await request.AttachmentFile.CopyToAsync(stream);
                        }

                        using (var stream = new FileStream(physicalFileName2, FileMode.Create, FileAccess.Write))
                        {
                            await request.IconFile.CopyToAsync(stream);
                        }

                        if (!string.IsNullOrWhiteSpace(entity.AttachmentUrl))
                        {
                            System.IO.File.Delete(Path.Combine(env.ContentRootPath,
                                                              "wwwroot",
                                                              "uploads",
                                                              "files",
                                                              entity.AttachmentUrl));
                        }

                        if (!string.IsNullOrWhiteSpace(entity.IconUrl))
                        {
                            System.IO.File.Delete(Path.Combine(env.ContentRootPath,
                                                              "wwwroot",
                                                              "uploads",
                                                              "images",
                                                              entity.IconUrl));
                        }

                        entity.AttachmentUrl = request.AttachmentUrl;
                        entity.IconUrl = request.IconUrl;

                    }

                    await db.SaveChangesAsync();
                    return entity.Id;

                }
                return 0;


            }
        }
    }
}
