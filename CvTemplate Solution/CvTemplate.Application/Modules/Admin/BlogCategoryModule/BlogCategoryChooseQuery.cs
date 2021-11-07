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

namespace CvTemplate.Application.Modules.Admin.BlogCategoryModule
{
    public class BlogCategoryChooseQuery : IRequest<List<BlogCategory>>
    {
        public class BlogCategoryChooseQueryHandler : IRequestHandler<BlogCategoryChooseQuery, List<BlogCategory>>
        {
            readonly CvTemplateDbContext db;
            public BlogCategoryChooseQueryHandler(CvTemplateDbContext db)
            {
                this.db = db;
            }

            public async Task<List<BlogCategory>> Handle(BlogCategoryChooseQuery request, CancellationToken cancellationToken)
            {
                var categories = await db.BlogCategories
                                    .Where(c => c.DeletedByUserId == null ).ToListAsync();
                return categories;
            }
        }
    }
}
