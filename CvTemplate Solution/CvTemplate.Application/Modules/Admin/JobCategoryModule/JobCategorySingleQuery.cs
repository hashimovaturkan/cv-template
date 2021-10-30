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

namespace CvTemplate.Application.Modules.Admin.JobCategoryModule
{
    public class JobCategorySingleQuery : IRequest<JobCategory>
    {
        public long? Id { get; set; }

        public class JobCategorySingleQueryHandler : IRequestHandler<JobCategorySingleQuery, JobCategory>
        {
            readonly CvTemplateDbContext db;
            public JobCategorySingleQueryHandler(CvTemplateDbContext db)
            {
                this.db = db;
            }
            public async Task<JobCategory> Handle(JobCategorySingleQuery request, CancellationToken cancellationToken)
            {
                if (request.Id == null && request.Id <= 0)
                    return null;

                var model = await db.JobCategories.FirstOrDefaultAsync(s => s.Id == request.Id && s.DeletedDate == null);

                return model;
            }
        }
    }
}
