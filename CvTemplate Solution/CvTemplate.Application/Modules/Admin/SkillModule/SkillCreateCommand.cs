using CvTemplate.Application.Core.Extensions;
using CvTemplate.Domain.Models.DataContexts;
using CvTemplate.Domain.Models.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CvTemplate.Application.Modules.Admin.SkillModule
{
    public class SkillCreateCommand : IRequest<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int? Level { get; set; }
        public bool IsBar { get; set; }
        public int? JobCategoryId { get; set; }
        public class SkillCreateCommandHandler : IRequestHandler<SkillCreateCommand, int>
        {
            readonly CvTemplateDbContext db;
            readonly IActionContextAccessor ctx;
            public SkillCreateCommandHandler(CvTemplateDbContext db, IActionContextAccessor ctx)
            {
                this.ctx = ctx;
                this.db = db;
            }
            public async Task<int> Handle(SkillCreateCommand request, CancellationToken cancellationToken)
            {
                if (ctx.IsModelStateValid())
                {
                    var model = new Skill();
                    model.Name = request.Name;
                    model.Description = request.Description;
                    model.Level = request.Level;
                    model.IsBar = request.IsBar;
                    model.JobCategoryId = request.JobCategoryId;

                    db.Skills.Add(model);
                    await db.SaveChangesAsync();

                    return model.Id;

                }

                return 0;

            }
        }
    }
}
