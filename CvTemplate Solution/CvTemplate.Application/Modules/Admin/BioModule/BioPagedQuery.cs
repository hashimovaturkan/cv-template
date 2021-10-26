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

namespace CvTemplate.Application.Modules.Admin.BioModule
{
    public class BioPagedQuery : IRequest<PagedViewModel<Bio>>
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 15;

        public class BioPagedQueryHandler : IRequestHandler<BioPagedQuery, PagedViewModel<Bio>>
        {
            readonly CvTemplateDbContext db;
            public BioPagedQueryHandler(CvTemplateDbContext db)
            {
                this.db = db;
            }
            public async Task<PagedViewModel<Bio>> Handle(BioPagedQuery request, CancellationToken cancellationToken)
            {
                var model = db.Bios.Where(s => s.DeletedByUserId == null).AsQueryable();

                return new PagedViewModel<Bio>(model, request.PageIndex, request.PageSize);
            }
        }
    }
}
