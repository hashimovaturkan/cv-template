using CvTemplate.Application.Modules.Admin.BlogPostModule;
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

namespace CvTemplate.Application.Modules.Admin.ExperienceModule
{
    public class ExperienceSingleQuery : IRequest<Experience>
    {
        public long? Id { get; set; }

        public class ExperienceSingleQueryHandler : IRequestHandler<ExperienceSingleQuery, Experience>
        {
            readonly CvTemplateDbContext db;
            public ExperienceSingleQueryHandler(CvTemplateDbContext db)
            {
                this.db = db;
            }
            public async Task<Experience> Handle(ExperienceSingleQuery request, CancellationToken cancellationToken)
            {
                if (request.Id == null && request.Id <= 0)
                    return null;

                var model = await db.Experiences.FirstOrDefaultAsync(s => s.Id == request.Id && s.DeletedDate == null);

                return model;
            }
        }
    }
}
