using CvTemplate.Domain.Models.DataContexts;
using CvTemplate.Domain.Models.Entities.Membership;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CvTemplate.Application.Modules.Admin.UsersModule
{
    public class UserChooseQuery : IRequest<List<CvTemplateUser>>
    {
        public class UserChooseQueryHandler : IRequestHandler<UserChooseQuery, List<CvTemplateUser>>
        {
            readonly CvTemplateDbContext db;
            public UserChooseQueryHandler(CvTemplateDbContext db)
            {
                this.db = db;
            }

            public async Task<List<CvTemplateUser>> Handle(UserChooseQuery request, CancellationToken cancellationToken)
            {
                var categories = await db.Users
                                    .Where(c => c.DeletedByUserId == null).ToListAsync();
                return categories;
            }
        }
    }
}
