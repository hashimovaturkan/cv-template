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

namespace CvTemplate.Application.Modules.Admin.AcademicBackGroundModule
{
    public class AcademicBackGroundPagedQuery : IRequest<PagedViewModel<AcademicBackGround>>
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 15;

        public class AcademicBackGroundPagedQueryHandler : IRequestHandler<AcademicBackGroundPagedQuery, PagedViewModel<AcademicBackGround>>
        {
            readonly CvTemplateDbContext db;
            public AcademicBackGroundPagedQueryHandler(CvTemplateDbContext db)
            {
                this.db = db;
            }
            public async Task<PagedViewModel<AcademicBackGround>> Handle(AcademicBackGroundPagedQuery request, CancellationToken cancellationToken)
            {
                var model = db.AcademicBackGrounds.Where(s => s.DeletedByUserId == null).AsQueryable();

                return new PagedViewModel<AcademicBackGround>(model, request.PageIndex, request.PageSize);
            }
        }
    }
}
