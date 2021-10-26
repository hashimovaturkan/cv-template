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

namespace CvTemplate.Application.Modules.Admin.BlogPostModule
{
    public class BlogPostCreateCommand : IRequest<int>
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Description { get; set; }
        public DateTime? PublishedDate { get; set; }
        public string ImgUrl { get; set; }
        public int BlogCategoryId { get; set; }
        public class BlogPostCreateCommandHandler : IRequestHandler<BlogPostCreateCommand, int>
        {
            readonly CvTemplateDbContext db;
            readonly IActionContextAccessor ctx;
            public BlogPostCreateCommandHandler(CvTemplateDbContext db, IActionContextAccessor ctx)
            {
                this.ctx = ctx;
                this.db = db;
            }
            public async Task<int> Handle(BlogPostCreateCommand request, CancellationToken cancellationToken)
            {
                if (ctx.IsModelStateValid())
                {
                    var model = new BlogPost();
                    model.Title = request.Title;
                    model.Content = request.Content;
                    model.PublishedDate = request.PublishedDate;
                    model.ImgUrl = request.ImgUrl;
                    model.BlogCategoryId = request.BlogCategoryId;

                    db.BlogPosts.Add(model);
                    await db.SaveChangesAsync();

                    return model.Id;

                }

                return 0;

            }
        }
    }
}
