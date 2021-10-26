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

namespace CvTemplate.Application.Modules.Admin.AcademicBackGroundModule
{
    public class AcademicBackGroundSingleQuery : IRequest<AcademicBackGround>
    {
        public long? Id { get; set; }

        public class AcademicBackGroundSingleQueryHandler : IRequestHandler<AcademicBackGroundSingleQuery, AcademicBackGround>
        {
            readonly CvTemplateDbContext db;
            public AcademicBackGroundSingleQueryHandler(CvTemplateDbContext db)
            {
                this.db = db;
            }
            public async Task<AcademicBackGround> Handle(AcademicBackGroundSingleQuery request, CancellationToken cancellationToken)
            {
                if (request.Id == null && request.Id <= 0)
                    return null;

                var model = await db.AcademicBackGrounds.FirstOrDefaultAsync(s => s.Id == request.Id && s.DeletedDate == null);

                return model;
            }
        }
    }
}
