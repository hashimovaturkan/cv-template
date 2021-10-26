using CvTemplate.Domain.Models.DataContexts;
using CvTemplate.Domain.Models.Entities.Membership;
using CvTemplate.Domain.Models.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CvTemplate.Application.Modules.Admin.UsersModule
{
    public class UserPagedQuery : IRequest<PagedViewModel<CvTemplateUser>>
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 15;

        public class UserPagedQueryHandler : IRequestHandler<UserPagedQuery, PagedViewModel<CvTemplateUser>>
        {
            readonly CvTemplateDbContext db;
            public UserPagedQueryHandler(CvTemplateDbContext db)
            {
                this.db = db;
            }
            public async Task<PagedViewModel<CvTemplateUser>> Handle(UserPagedQuery request, CancellationToken cancellationToken)
            {
                var model = db.Users.Where(s => s.DeletedByUserId == null).AsQueryable();

                return new PagedViewModel<CvTemplateUser>(model, request.PageIndex, request.PageSize);
            }
        }
    }
}
