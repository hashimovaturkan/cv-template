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

namespace CvTemplate.Application.Modules.Admin.ContactPostModule
{
    public class ContactPostSingleQuery : IRequest<ContactPost>
    {
        public int? Id { get; set; }

        public class ContactPostSingleQueryHandler : IRequestHandler<ContactPostSingleQuery, ContactPost>
        {
            readonly CvTemplateDbContext db;
            public ContactPostSingleQueryHandler(CvTemplateDbContext db)
            {
                this.db = db;
            }
            public async Task<ContactPost> Handle(ContactPostSingleQuery request, CancellationToken cancellationToken)
            {
                if (request.Id == null && request.Id <= 0)
                    return null;

                var model = await db.ContactPosts.FirstOrDefaultAsync(m => m.Id == request.Id
                                    && m.DeletedByUserId == null
                                    && m.AnswerDate == null);

                return model;
            }
        }
    }
}
