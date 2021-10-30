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

namespace CvTemplate.Application.Modules.Admin.SocialProfileModule
{
    public class SocialProfileSingleQuery : IRequest<SocialProfile>
    {
        public long? Id { get; set; }

        public class SocialProfileSingleQueryHandler : IRequestHandler<SocialProfileSingleQuery, SocialProfile>
        {
            readonly CvTemplateDbContext db;
            public SocialProfileSingleQueryHandler(CvTemplateDbContext db)
            {
                this.db = db;
            }
            public async Task<SocialProfile> Handle(SocialProfileSingleQuery request, CancellationToken cancellationToken)
            {
                if (request.Id == null && request.Id <= 0)
                    return null;

                var model = await db.SocialProfiles.FirstOrDefaultAsync(s => s.Id == request.Id && s.DeletedDate == null);

                return model;
            }
        }
    }
}
