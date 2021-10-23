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

namespace CvTemplate.Application.Modules.Admin.PersonalSettingsModule
{
    public class PersonalSettingUpdateCommand : PersonalSettingViewModel, IRequest<int>
    {
        public class PersonalSettingUpdateCommandHandler : IRequestHandler<PersonalSettingUpdateCommand, int>
        {
            readonly CvTemplateDbContext db;
            readonly IActionContextAccessor ctx;
            public PersonalSettingUpdateCommandHandler(CvTemplateDbContext db, IActionContextAccessor ctx)
            {
                this.ctx = ctx;
                this.db = db;
            }
            public async Task<int> Handle(PersonalSettingUpdateCommand request, CancellationToken cancellationToken)
            {
                if (request.Id == null || request.Id <= 0)
                    return 0;

                var model = db.PersonalSettings.FirstOrDefault(s => s.Id == request.Id && s.DeletedByUserId == null);
                if (model == null)
                    return 0;

                if (ctx.IsModelStateValid())
                {
                    model.Age = request.Age;
                    model.Name = request.Name;
                    model.Experience = request.Experience;
                    model.CareerLevel = request.CareerLevel;
                    model.Degree = request.Degree;
                    model.Location = request.Location;
                    model.Phone = request.Phone;
                    model.Fax = request.Fax;
                    model.Website = request.Website;
                    model.Email = request.Email;
                    model.CvTemplateUserId = request.CvTemplateUserId;

                    await db.SaveChangesAsync(cancellationToken);

                    return model.Id;
                }
                return 0;
            }
        }
    }
}
