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
    public class JobCategoryChooseQuery : IRequest<List<JobCategory>>
    {
        public class JobCategoryChooseQueryHandler : IRequestHandler<JobCategoryChooseQuery, List<JobCategory>>
        {
            readonly CvTemplateDbContext db;
            public JobCategoryChooseQueryHandler(CvTemplateDbContext db)
            {
                this.db = db;
            }

            public async Task<List<JobCategory>> Handle(JobCategoryChooseQuery request, CancellationToken cancellationToken)
            {
                var categories = await db.JobCategories
                                    .Where(c => c.DeletedByUserId == null).ToListAsync();
                return categories;
            }
        }
    }
}
