using CvTemplate.Application.Core.Extensions;
using CvTemplate.Domain.Models.DataContexts;
using CvTemplate.Domain.Models.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CvTemplate.Application.Modules.Admin.BlogCategoryModule
{
    public class BlogCategoryCreateCommand : IRequest<int>
    {
        public string Name { get; set; }
       
        public class BlogCategoryCreateCommandHandler : IRequestHandler<BlogCategoryCreateCommand, int>
        {
            readonly CvTemplateDbContext db;
            readonly IActionContextAccessor ctx;
            public BlogCategoryCreateCommandHandler(CvTemplateDbContext db, IActionContextAccessor ctx)
            {
                this.ctx = ctx;
                this.db = db;
            }
            public async Task<int> Handle(BlogCategoryCreateCommand request, CancellationToken cancellationToken)
            {
                if (ctx.IsModelStateValid())
                {
                    var model = new BlogCategory();
                    model.Name = request.Name;

                    db.BlogCategories.Add(model);
                    await db.SaveChangesAsync();

                    return model.Id;

                }

                return 0;

            }
        }
    }
}
