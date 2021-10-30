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

namespace CvTemplate.Application.Modules.Admin.ExperienceModule
{
    public class ExperiencePagedQuery : IRequest<PagedViewModel<Experience>>
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 15;

        public class ExperiencePagedQueryHandler : IRequestHandler<ExperiencePagedQuery, PagedViewModel<Experience>>
        {
            readonly CvTemplateDbContext db;
            public ExperiencePagedQueryHandler(CvTemplateDbContext db)
            {
                this.db = db;
            }
            public async Task<PagedViewModel<Experience>> Handle(ExperiencePagedQuery request, CancellationToken cancellationToken)
            {
                var model = db.Experiences.Where(s => s.DeletedByUserId == null).AsQueryable();

                return new PagedViewModel<Experience>(model, request.PageIndex, request.PageSize);
            }
        }
    }
}
