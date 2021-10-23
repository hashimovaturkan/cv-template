using CvTemplate.Domain.Models.DataContexts;
using CvTemplate.Domain.Models.Entities;
using CvTemplate.Domain.Models.Entities.Membership;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CvTemplate.Application.Modules.Admin.PersonalSettingsModule
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
                var users = await db.Users.ToListAsync();
                return users;
            }
        }
    }
}
