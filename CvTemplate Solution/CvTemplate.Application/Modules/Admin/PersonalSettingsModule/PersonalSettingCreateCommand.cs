using CvTemplate.Application.Core.Extensions;
using CvTemplate.Domain.Models.DataContexts;
using CvTemplate.Domain.Models.Entities;
using MediatR;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CvTemplate.Application.Modules.Admin.PersonalSettingsModule
{
    class PersonalSettingCreateCommand : IRequest<long>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Location { get; set; }
        public string Experience { get; set; }
        public string Degree { get; set; }
        public string CareerLevel { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Website { get; set; }
        public string Email { get; set; }
        public int? CvTemplateUserId { get; set; }
        public class PersonalSettingCreateCommandHandler : IRequestHandler<PersonalSettingCreateCommand, long>
        {
            readonly CvTemplateDbContext db;
            readonly IActionContextAccessor ctx;
            readonly IWebHostEnvironment env;
            public PersonalSettingCreateCommandHandler(CvTemplateDbContext db, IActionContextAccessor ctx, IWebHostEnvironment env)
            {
                this.env = env;
                this.ctx = ctx;
                this.db = db;
            }
            public async Task<long> Handle(PersonalSettingCreateCommand request, CancellationToken cancellationToken)
            {
                if (ctx.IsModelStateValid())
                {
                    var model = new PersonalSetting();
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

                    db.PersonalSettings.Add(model);
                    await db.SaveChangesAsync();

                    return model.Id;

                }

                return 0;

            }
        }
    }
}
