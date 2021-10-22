using CvTemplate.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvTemplate.Domain.Models.ViewModels
{
    public class SidebarViewModel
    {
        public PersonalSetting PersonalSetting { get; set; }
        public IEnumerable<Attachment> Attachments { get; set; }
        public IEnumerable<SocialProfile> SocialProfiles { get; set; }
        public ContactPost ContactPost { get; set; }
    }
}
