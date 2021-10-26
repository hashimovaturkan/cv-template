﻿using CvTemplate.Application.Core.Infrastructure;
using CvTemplate.Domain.Models.DataContexts;
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
    public class UserDeleteCommand : IRequest<CommandJsonResponse>
    {
        public int? Id { get; set; }

        public class UserDeleteCommandHandler : IRequestHandler<UserDeleteCommand, CommandJsonResponse>
        {
            readonly CvTemplateDbContext db;
            public UserDeleteCommandHandler(CvTemplateDbContext db)
            {
                this.db = db;
            }
            public async Task<CommandJsonResponse> Handle(UserDeleteCommand request, CancellationToken cancellationToken)
            {
                var response = new CommandJsonResponse();

                if (request.Id == null && request.Id <= 0)
                {
                    response.Error = true;
                    response.Message = "The information is incomplete!";
                    return response;
                }

                var size =await db.Users.FirstOrDefaultAsync(s => s.Id == request.Id && s.DeletedByUserId == null);
                if (size == null)
                {
                    response.Error = true;
                    response.Message = "There is no data!";
                    return response;
                }

                size.DeletedByUserId = 1;
                size.DeletedDate = DateTime.Now;
                response.Error = false;
                response.Message = "Successfully operation!";

                await db.SaveChangesAsync(cancellationToken);

                return response;

            }
        }
    }
}
