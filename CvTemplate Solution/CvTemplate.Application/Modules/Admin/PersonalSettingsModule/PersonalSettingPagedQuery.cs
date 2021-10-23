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

namespace CvTemplate.Application.Modules.Admin.PersonalSettingsModule
{
    public class PersonalSettingPagedQuery : IRequest<PagedViewModel<PersonalSetting>>
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 15;

        public class PersonalSettingPagedQueryHandler : IRequestHandler<PersonalSettingPagedQuery, PagedViewModel<PersonalSetting>>
        {
            readonly CvTemplateDbContext db;
            public PersonalSettingPagedQueryHandler(CvTemplateDbContext db)
            {
                this.db = db;
            }
            public async Task<PagedViewModel<PersonalSetting>> Handle(PersonalSettingPagedQuery request, CancellationToken cancellationToken)
            {
                var sizes = db.PersonalSettings.Where(s => s.DeletedByUserId == null).AsQueryable();

                return new PagedViewModel<PersonalSetting>(sizes, request.PageIndex, request.PageSize);
            }
        }
    }
}
