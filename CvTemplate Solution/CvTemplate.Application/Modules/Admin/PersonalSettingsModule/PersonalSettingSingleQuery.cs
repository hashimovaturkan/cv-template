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

namespace CvTemplate.Application.Modules.Admin.PersonalSettingsModule
{
    public class PersonalSettingSingleQuery : IRequest<PersonalSetting>
    {
        public long? Id { get; set; }

        public class PersonalSettingSingleQueryHandler : IRequestHandler<PersonalSettingSingleQuery, PersonalSetting>
        {
            readonly CvTemplateDbContext db;
            public PersonalSettingSingleQueryHandler(CvTemplateDbContext db)
            {
                this.db = db;
            }
            public async Task<PersonalSetting> Handle(PersonalSettingSingleQuery request, CancellationToken cancellationToken)
            {
                if (request.Id == null && request.Id <= 0)
                    return null;

                var model =await db.PersonalSettings.FirstOrDefaultAsync(s => s.Id == request.Id && s.DeletedDate == null);

                return model;
            }
        }
    }
}
