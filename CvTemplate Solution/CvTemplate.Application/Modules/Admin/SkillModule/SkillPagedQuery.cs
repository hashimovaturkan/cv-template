using CvTemplate.Domain.Models.DataContexts;
using CvTemplate.Domain.Models.Entities;
using CvTemplate.Domain.Models.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CvTemplate.Application.Modules.Admin.SkillModule
{
    public class SkillPagedQuery : IRequest<PagedViewModel<Skill>>
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 15;

        public class SkillPagedQueryHandler : IRequestHandler<SkillPagedQuery, PagedViewModel<Skill>>
        {
            readonly CvTemplateDbContext db;
            public SkillPagedQueryHandler(CvTemplateDbContext db)
            {
                this.db = db;
            }
            public async Task<PagedViewModel<Skill>> Handle(SkillPagedQuery request, CancellationToken cancellationToken)
            {
                var model = db.Skills.Where(s => s.DeletedByUserId == null).AsQueryable();

                return new PagedViewModel<Skill>(model, request.PageIndex, request.PageSize);
            }
        }
    }
}
