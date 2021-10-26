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

namespace CvTemplate.Application.Modules.Admin.AcademicBackGroundModule
{
    public class AcademicBackGroundUpdateCommand : AcademicBackGroundViewModel, IRequest<int>
    {
        public class AcademicBackGroundUpdateCommandHandler : IRequestHandler<AcademicBackGroundUpdateCommand, int>
        {
            readonly CvTemplateDbContext db;
            readonly IActionContextAccessor ctx;
            readonly IWebHostEnvironment env;
            public AcademicBackGroundUpdateCommandHandler(CvTemplateDbContext db, IActionContextAccessor ctx, IWebHostEnvironment env)
            {
                this.ctx = ctx;
                this.db = db;
                this.env = env;
            }
            public async Task<int> Handle(AcademicBackGroundUpdateCommand request, CancellationToken cancellationToken)
            {
                if (request.Id == null || request.Id <= 0)
                    return 0;

                if (string.IsNullOrWhiteSpace(request.fileTemp) && request.file == null)
                {
                    ctx.ActionContext.ModelState.AddModelError("file", "Image was added!");
                }

                if (ctx.IsModelStateValid())
                {
                    var entity = await db.AcademicBackGrounds.FirstOrDefaultAsync(b => b.Id == request.Id && b.DeletedByUserId == null);

                    if (entity == null)
                    {
                        return 0;
                    }

                    entity.Degree = request.Degree;
                    entity.Name = request.Name;
                    entity.Qualification = request.Qualification;
                    entity.University = request.University;
                    entity.Details = request.Details;
                    entity.StartingDate = request.StartingDate;
                    entity.EndingDate = request.EndingDate;

                    if (request.file != null)
                    {
                        string extension = Path.GetExtension(request.file.FileName);
                        request.ImageUrl = $"{Guid.NewGuid()}{extension}";

                        string physicalFileName = Path.Combine(env.ContentRootPath,
                                                               "wwwroot",
                                                               "uploads",
                                                               "images",
                                                               "blog",
                                                               "mask",
                                                               request.ImageUrl);

                        using (var stream = new FileStream(physicalFileName, FileMode.Create, FileAccess.Write))
                        {
                            await request.file.CopyToAsync(stream);
                        }

                        if (!string.IsNullOrWhiteSpace(entity.ImageUrl))
                        {
                            System.IO.File.Delete(Path.Combine(env.ContentRootPath,
                                                              "wwwroot",
                                                              "uploads",
                                                              "images",
                                                              "blog",
                                                              "mask",
                                                              entity.ImageUrl));
                        }

                        entity.ImageUrl = request.ImageUrl;

                    }

                    await db.SaveChangesAsync();
                    return entity.Id;

                }
                return 0;

                
            }
        }
    }
}
