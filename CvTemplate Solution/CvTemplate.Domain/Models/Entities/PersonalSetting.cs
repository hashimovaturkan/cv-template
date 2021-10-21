using CvTemplate.Domain.Models.Entities.Membership;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvTemplate.Domain.Models.Entities
{
    public class PersonalSetting:BaseEntity
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
        public virtual CvTemplateUser CvTemplateUser { get; set; }
    }
}
