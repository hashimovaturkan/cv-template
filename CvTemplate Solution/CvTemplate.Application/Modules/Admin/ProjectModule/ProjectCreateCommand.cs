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

namespace CvTemplate.Application.Modules.Admin.ProjectModule
{
    public class ProjectCreateCommand : IRequest<int>
    {
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public int JobCategoryId { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
        public IFormFile file { get; set; }
        public class ProjectCreateCommandHandler : IRequestHandler<ProjectCreateCommand, int>
        {
            readonly CvTemplateDbContext db;
            readonly IActionContextAccessor ctx;
            readonly IWebHostEnvironment env;
            public ProjectCreateCommandHandler(CvTemplateDbContext db, IActionContextAccessor ctx, IWebHostEnvironment env)
            {
                this.ctx = ctx;
                this.db = db;
                this.env = env;
            }
            public async Task<int> Handle(ProjectCreateCommand request, CancellationToken cancellationToken)
            {
                if(request.file == null)
                {
                    ctx.ActionContext.ModelState.AddModelError("file", "There is not image");
                }

                if (ctx.IsModelStateValid())
                {
                    var model = new Project();
                    model.Name = request.Name;
                    model.ShortDescription = request.ShortDescription;
                    model.JobCategoryId = request.JobCategoryId;
                    model.Description = request.Description;

                    string extension = Path.GetExtension(request.file.FileName);
                    model.ImgUrl = $"{Guid.NewGuid()}{extension}";

                    string physicalFileName = Path.Combine(env.ContentRootPath,
                                                           "wwwroot",
                                                           "uploads",
                                                           "images",
                                                           model.ImgUrl);

                    using (var stream = new FileStream(physicalFileName, FileMode.Create, FileAccess.Write))
                    {
                        await request.file.CopyToAsync(stream);
                    }

                    db.Projects.Add(model);
                    await db.SaveChangesAsync();

                    return model.Id;
                }

                return 0;

            }
        }
    }
}
