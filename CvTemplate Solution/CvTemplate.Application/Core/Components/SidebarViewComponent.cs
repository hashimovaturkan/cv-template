using CvTemplate.Domain.Models.DataContexts;
using CvTemplate.Domain.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvTemplate.Application.Core.Components
{
    public class SidebarViewComponent:ViewComponent
    {
        readonly CvTemplateDbContext db;
        public SidebarViewComponent(CvTemplateDbContext db)
        {
            this.db = db;
        }
        public IViewComponentResult Invoke()
        {
            var personalSetting = db.PersonalSettings.FirstOrDefault(c => c.DeletedByUserId == null);
            var attachments = db.Attachments.Where(c => c.DeletedByUserId == null).ToList();
            var socialProfiles = db.SocialProfiles.Where(c => c.DeletedByUserId == null).ToList();
            var contactPost = db.ContactPosts.FirstOrDefault(c => c.DeletedByUserId == null);

            var data = new SidebarViewModel()
            {
                PersonalSetting = personalSetting,
                Attachments = attachments,
                SocialProfiles = socialProfiles,
                ContactPost = contactPost

            };
            return View(data);
        }
    }
}
