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

namespace CvTemplate.Application.Modules.Admin.AttachmentModule
{
    public class AttachmentSingleQuery : IRequest<Attachment>
    {
        public long? Id { get; set; }

        public class AttachmentSingleQueryHandler : IRequestHandler<AttachmentSingleQuery, Attachment>
        {
            readonly CvTemplateDbContext db;
            public AttachmentSingleQueryHandler(CvTemplateDbContext db)
            {
                this.db = db;
            }
            public async Task<Attachment> Handle(AttachmentSingleQuery request, CancellationToken cancellationToken)
            {
                if (request.Id == null && request.Id <= 0)
                    return null;

                var model = await db.Attachments.FirstOrDefaultAsync(s => s.Id == request.Id && s.DeletedDate == null);

                return model;
            }
        }
    }
}
