using CvTemplate.Domain.Models.DataContexts;
using CvTemplate.Domain.Models.Entities;
using CvTemplate.Domain.Models.ViewModels;
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
    public class JobCategoryPagedQuery : IRequest<PagedViewModel<JobCategory>>
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 15;

        public class JobCategoryPagedQueryHandler : IRequestHandler<JobCategoryPagedQuery, PagedViewModel<JobCategory>>
        {
            readonly CvTemplateDbContext db;
            public JobCategoryPagedQueryHandler(CvTemplateDbContext db)
            {
                this.db = db;
            }
            public async Task<PagedViewModel<JobCategory>> Handle(JobCategoryPagedQuery request, CancellationToken cancellationToken)
            {
                var model = db.JobCategories
                    .Where(s => s.DeletedByUserId == null)
                    .AsQueryable();

                return new PagedViewModel<JobCategory>(model, request.PageIndex, request.PageSize);
            }
        }
    }
}
