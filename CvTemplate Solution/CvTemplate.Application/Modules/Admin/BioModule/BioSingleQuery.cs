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

namespace CvTemplate.Application.Modules.Admin.BioModule
{
    public class BioSingleQuery : IRequest<Bio>
    {
        public long? Id { get; set; }

        public class BioSingleQueryHandler : IRequestHandler<BioSingleQuery, Bio>
        {
            readonly CvTemplateDbContext db;
            public BioSingleQueryHandler(CvTemplateDbContext db)
            {
                this.db = db;
            }
            public async Task<Bio> Handle(BioSingleQuery request, CancellationToken cancellationToken)
            {
                if (request.Id == null && request.Id <= 0)
                    return null;

                var model = await db.Bios.FirstOrDefaultAsync(s => s.Id == request.Id && s.DeletedDate == null);

                return model;
            }
        }
    }
}
