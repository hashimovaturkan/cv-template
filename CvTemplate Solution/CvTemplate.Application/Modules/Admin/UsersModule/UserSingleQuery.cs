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
    public class UserSingleQuery : IRequest<CvTemplateUser>
    {
        public long? Id { get; set; }

        public class UserSingleQueryHandler : IRequestHandler<UserSingleQuery, CvTemplateUser>
        {
            readonly CvTemplateDbContext db;
            public UserSingleQueryHandler(CvTemplateDbContext db)
            {
                this.db = db;
            }
            public async Task<CvTemplateUser> Handle(UserSingleQuery request, CancellationToken cancellationToken)
            {
                if (request.Id == null && request.Id <= 0)
                    return null;

                var model =await db.Users.FirstOrDefaultAsync(s => s.Id == request.Id && s.DeletedDate == null);

                return model;
            }
        }
    }
}
