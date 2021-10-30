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

namespace CvTemplate.Application.Modules.Admin.ExperienceModule
{
    public class ExperienceCreateCommand : IRequest<int>
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Job { get; set; }
        public string Company { get; set; }
        public string Details { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime EndingDate { get; set; }
        public string ImageUrl { get; set; }
        public IFormFile file { get; set; }
        public class ExperienceCreateCommandHandler : IRequestHandler<ExperienceCreateCommand, int>
        {
            readonly CvTemplateDbContext db;
            readonly IActionContextAccessor ctx;
            readonly IWebHostEnvironment env;
            public ExperienceCreateCommandHandler(CvTemplateDbContext db, IActionContextAccessor ctx, IWebHostEnvironment env)
            {
                this.ctx = ctx;
                this.db = db;
                this.env = env;
            }
            public async Task<int> Handle(ExperienceCreateCommand request, CancellationToken cancellationToken)
            {
                if (request.file == null)
                {
                    ctx.ActionContext.ModelState.AddModelError("file", "There is not image");
                }

                if (ctx.IsModelStateValid())
                {
                    var model = new Experience();
                    model.Name = request.Name;
                    model.Location = request.Location;
                    model.Job = request.Job;
                    model.Company = request.Company;
                    model.Details = request.Details;
                    model.StartingDate = request.StartingDate;
                    model.EndingDate = request.EndingDate;

                    string extension = Path.GetExtension(request.file.FileName);
                    model.ImageUrl = $"{Guid.NewGuid()}{extension}";

                    string physicalFileName = Path.Combine(env.ContentRootPath,
                                                           "wwwroot",
                                                           "uploads",
                                                           "images",
                                                           model.ImageUrl);

                    using (var stream = new FileStream(physicalFileName, FileMode.Create, FileAccess.Write))
                    {
                        await request.file.CopyToAsync(stream);
                    }

                    db.Experiences.Add(model);
                    await db.SaveChangesAsync();

                    return model.Id;
                }

                return 0;

            }
        }
    }
}
