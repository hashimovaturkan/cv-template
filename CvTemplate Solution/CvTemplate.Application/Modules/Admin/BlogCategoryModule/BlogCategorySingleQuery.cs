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
    public class BlogCategorySingleQuery : IRequest<BlogCategory>
    {
        public long? Id { get; set; }

        public class BlogCategorySingleQueryHandler : IRequestHandler<BlogCategorySingleQuery, BlogCategory>
        {
            readonly CvTemplateDbContext db;
            public BlogCategorySingleQueryHandler(CvTemplateDbContext db)
            {
                this.db = db;
            }
            public async Task<BlogCategory> Handle(BlogCategorySingleQuery request, CancellationToken cancellationToken)
            {
                if (request.Id == null && request.Id <= 0)
                    return null;

                var model = await db.BlogCategories.FirstOrDefaultAsync(s => s.Id == request.Id && s.DeletedDate == null);

                return model;
            }
        }
    }
}
