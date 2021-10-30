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

namespace CvTemplate.Application.Modules.Admin.ProjectModule
{
    public class ProjectPagedQuery : IRequest<PagedViewModel<Project>>
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 15;

        public class ProjectPagedQueryHandler : IRequestHandler<ProjectPagedQuery, PagedViewModel<Project>>
        {
            readonly CvTemplateDbContext db;
            public ProjectPagedQueryHandler(CvTemplateDbContext db)
            {
                this.db = db;
            }
            public async Task<PagedViewModel<Project>> Handle(ProjectPagedQuery request, CancellationToken cancellationToken)
            {
                var model = db.Projects.Where(s => s.DeletedByUserId == null).AsQueryable();

                return new PagedViewModel<Project>(model, request.PageIndex, request.PageSize);
            }
        }
    }
}
