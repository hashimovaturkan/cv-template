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

namespace CvTemplate.Application.Modules.Admin.AttachmentModule
{
    public class AttachmentPagedQuery : IRequest<PagedViewModel<Attachment>>
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 15;

        public class AttachmentPagedQueryyHandler : IRequestHandler<AttachmentPagedQuery, PagedViewModel<Attachment>>
        {
            readonly CvTemplateDbContext db;
            public AttachmentPagedQueryyHandler(CvTemplateDbContext db)
            {
                this.db = db;
            }
            public async Task<PagedViewModel<Attachment>> Handle(AttachmentPagedQuery request, CancellationToken cancellationToken)
            {
                var model = db.Attachments.Where(s => s.DeletedByUserId == null).AsQueryable();

                return new PagedViewModel<Attachment>(model, request.PageIndex, request.PageSize);
            }
        }
    }
}
