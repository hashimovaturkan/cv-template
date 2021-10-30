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

namespace CvTemplate.Application.Modules.Admin.SocialProfileModule
{
    public class SocialProfilePagedQuery : IRequest<PagedViewModel<SocialProfile>>
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 15;

        public class SocialProfilePagedQueryHandler : IRequestHandler<SocialProfilePagedQuery, PagedViewModel<SocialProfile>>
        {
            readonly CvTemplateDbContext db;
            public SocialProfilePagedQueryHandler(CvTemplateDbContext db)
            {
                this.db = db;
            }
            public async Task<PagedViewModel<SocialProfile>> Handle(SocialProfilePagedQuery request, CancellationToken cancellationToken)
            {
                var model = db.SocialProfiles.Where(s => s.DeletedByUserId == null).AsQueryable();

                return new PagedViewModel<SocialProfile>(model, request.PageIndex, request.PageSize);
            }
        }
    }
}
