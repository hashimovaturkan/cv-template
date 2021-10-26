using CvTemplate.Application.Core.Extensions;
using CvTemplate.Domain.Models.DataContexts;
using MediatR;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CvTemplate.Application.Modules.Admin.UsersModule
{
    public class UserUpdateCommand : UserViewModel, IRequest<int>
    {
        public class UserUpdateCommandHandler : IRequestHandler<UserUpdateCommand, int>
        {
            readonly CvTemplateDbContext db;
            readonly IActionContextAccessor ctx;
            public UserUpdateCommandHandler(CvTemplateDbContext db, IActionContextAccessor ctx)
            {
                this.ctx = ctx;
                this.db = db;
            }
            public async Task<int> Handle(UserUpdateCommand request, CancellationToken cancellationToken)
            {
                if (request.Id == null || request.Id <= 0)
                    return 0;

                var model = db.Users.FirstOrDefault(s => s.Id == request.Id && s.DeletedByUserId == null);
                if (model == null)
                    return 0;

                if (ctx.IsModelStateValid())
                {
                    model.UserName = request.UserName;
                    model.Email = request.Email;
                    model.EmailConfirmed = request.EmailConfirmed;
                    model.PhoneNumber = request.PhoneNumber;

                    await db.SaveChangesAsync(cancellationToken);

                    return model.Id;
                }
                return 0;
            }
        }
    }
}
