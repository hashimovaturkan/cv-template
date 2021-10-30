using CvTemplate.Application.Core.Extensions;
using CvTemplate.Domain.Models.DataContexts;
using CvTemplate.Domain.Models.Entities;
using CvTemplate.Domain.Models.Enums;
using MediatR;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CvTemplate.Application.Modules.Admin.JobCategoryModule
{
    public class JobCategoryCreateCommand : IRequest<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public SkillType SkillType { get; set; }
        public class JobCategoryCreateCommandHandler : IRequestHandler<JobCategoryCreateCommand, int>
        {
            readonly CvTemplateDbContext db;
            readonly IActionContextAccessor ctx;
            public JobCategoryCreateCommandHandler(CvTemplateDbContext db, IActionContextAccessor ctx)
            {
                this.ctx = ctx;
                this.db = db;
            }
            public async Task<int> Handle(JobCategoryCreateCommand request, CancellationToken cancellationToken)
            {
                if (ctx.IsModelStateValid())
                {
                    var model = new JobCategory();
                    model.Name = request.Name;
                    model.Description = request.Description;
                    model.SkillType = request.SkillType;

                    db.JobCategories.Add(model);
                    await db.SaveChangesAsync();

                    return model.Id;

                }

                return 0;

            }
        }
    }
}
