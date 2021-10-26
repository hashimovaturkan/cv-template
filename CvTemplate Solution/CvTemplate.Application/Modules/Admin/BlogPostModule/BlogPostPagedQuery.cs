using CvTemplate.Domain.Models.DataContexts;
using CvTemplate.Domain.Models.Entities;
using CvTemplate.Domain.Models.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CvTemplate.Application.Modules.Admin.BlogPostModule
{
    public class BlogPostPagedQuery : IRequest<PagedViewModel<BlogPost>>
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 15;

        public class BlogPostPagedQueryHandler : IRequestHandler<BlogPostPagedQuery, PagedViewModel<BlogPost>>
        {
            readonly CvTemplateDbContext db;
            public BlogPostPagedQueryHandler(CvTemplateDbContext db)
            {
                this.db = db;
            }
            public async Task<PagedViewModel<BlogPost>> Handle(BlogPostPagedQuery request, CancellationToken cancellationToken)
            {
                var model = db.BlogPosts.Where(s => s.DeletedByUserId == null).AsQueryable();

                return new PagedViewModel<BlogPost>(model, request.PageIndex, request.PageSize);
            }
        }
    }
}
