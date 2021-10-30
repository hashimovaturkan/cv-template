using CvTemplate.Domain.Models.DataContexts;
using CvTemplate.Domain.Models.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CvTemplate.Application.Modules.Admin.SkillModule
{
    public class SkillSingleQuery : IRequest<Skill>
    {
        public long? Id { get; set; }

        public class SkillSingleQueryHandler : IRequestHandler<SkillSingleQuery, Skill>
        {
            readonly CvTemplateDbContext db;
            public SkillSingleQueryHandler(CvTemplateDbContext db)
            {
                this.db = db;
            }
            public async Task<Skill> Handle(SkillSingleQuery request, CancellationToken cancellationToken)
            {
                if (request.Id == null && request.Id <= 0)
                    return null;

                var model = await db.Skills.FirstOrDefaultAsync(s => s.Id == request.Id && s.DeletedDate == null);

                return model;
            }
        }
    }
}
