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

namespace CvTemplate.Application.Modules.Admin.ServiceModule
{
    public class ServiceSingleQuery : IRequest<Service>
    {
        public long? Id { get; set; }

        public class ServiceSingleQueryHandler : IRequestHandler<ServiceSingleQuery, Service>
        {
            readonly CvTemplateDbContext db;
            public ServiceSingleQueryHandler(CvTemplateDbContext db)
            {
                this.db = db;
            }
            public async Task<Service> Handle(ServiceSingleQuery request, CancellationToken cancellationToken)
            {
                if (request.Id == null && request.Id <= 0)
                    return null;

                var model = await db.Services.FirstOrDefaultAsync(s => s.Id == request.Id && s.DeletedDate == null);

                return model;
            }
        }
    }
}
