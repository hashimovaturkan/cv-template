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

namespace CvTemplate.Application.Modules.Admin.ContactPostModule
{
    public class ContactPostPagedQuery : IRequest<ContactPostViewModel>
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 15;
        public int? typeId { get; set; }

        public class ContactPostPagedQueryHandler : IRequestHandler<ContactPostPagedQuery, ContactPostViewModel>
        {
            readonly CvTemplateDbContext db;
            public ContactPostPagedQueryHandler(CvTemplateDbContext db)
            {
                this.db = db;
            }
            public async Task<ContactPostViewModel> Handle(ContactPostPagedQuery request, CancellationToken cancellationToken)
            {
                var query = db.ContactPosts.AsQueryable()
                        .Where(q => q.DeletedByUserId == null);
                var model =new ContactPostViewModel();


                model.InboxCount = query.Count();
                model.UnreadCount = query.Where(q => q.AnswerByUserId == null).Count();
                model.SentCount = query.Where(q => q.AnswerByUserId != null).Count();

                if(request.typeId != null)
                {
                    switch (request.typeId)
                    {
                        case 1:
                            query = query.Where(q => q.AnswerByUserId == null);
                            break;
                        case 2:
                            query = query.Where(q => q.AnswerByUserId != null);
                            break;
                        default:
                            break;

                    }
                }

                model.ContactPagedViewModel = new PagedViewModel<ContactPost>(query, request.PageIndex, request.PageSize);
                return model;
            }
        }
    }
}
