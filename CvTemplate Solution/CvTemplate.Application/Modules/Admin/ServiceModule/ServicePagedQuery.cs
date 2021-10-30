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

namespace CvTemplate.Application.Modules.Admin.ServiceModule
{
    public class ServicePagedQuery : IRequest<PagedViewModel<Service>>
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 15;

        public class ServicePagedQueryHandler : IRequestHandler<ServicePagedQuery, PagedViewModel<Service>>
        {
            readonly CvTemplateDbContext db;
            public ServicePagedQueryHandler(CvTemplateDbContext db)
            {
                this.db = db;
            }
            public async Task<PagedViewModel<Service>> Handle(ServicePagedQuery request, CancellationToken cancellationToken)
            {
                var model = db.Services.Where(s => s.DeletedByUserId == null).AsQueryable();

                return new PagedViewModel<Service>(model, request.PageIndex, request.PageSize);
            }
        }
    }
}
