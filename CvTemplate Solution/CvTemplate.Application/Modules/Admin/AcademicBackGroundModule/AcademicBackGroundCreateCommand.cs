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

namespace CvTemplate.Application.Modules.Admin.AcademicBackGroundModule
{
    public class AcademicBackGroundCreateCommand : IRequest<int>
    {
        public string Name { get; set; }
        public string Degree { get; set; }
        public string Qualification { get; set; }
        public string University { get; set; }
        public string Details { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime EndingDate { get; set; }
        public IFormFile file { get; set; }
        public class AcademicBackGroundCreateCommandHandler : IRequestHandler<AcademicBackGroundCreateCommand, int>
        {
            readonly CvTemplateDbContext db;
            readonly IActionContextAccessor ctx;
            readonly IWebHostEnvironment env;
            public AcademicBackGroundCreateCommandHandler(CvTemplateDbContext db, IActionContextAccessor ctx, IWebHostEnvironment env)
            {
                this.ctx = ctx;
                this.db = db;
                this.env = env;
            }
            public async Task<int> Handle(AcademicBackGroundCreateCommand request, CancellationToken cancellationToken)
            {
                if (request.file == null)
                {
                    ctx.ActionContext.ModelState.AddModelError("file", "There is not image");
                }

                if (ctx.IsModelStateValid())
                {
                    var model = new AcademicBackGround();
                    model.Degree = request.Degree;
                    model.Name = request.Name;
                    model.Qualification = request.Qualification;
                    model.University = request.University;
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

                    db.AcademicBackGrounds.Add(model);
                    await db.SaveChangesAsync();

                    return model.Id;
                }

                return 0;

            }
        }
    }
}
