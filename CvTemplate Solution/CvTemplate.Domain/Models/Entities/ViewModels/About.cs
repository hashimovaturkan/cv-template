using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvTemplate.Domain.Models.Entities.ViewModels
{
    class About
    {
        public PersonalSetting PersonalSetting { get; set; }
        public Bio Bio { get; set; }
        public IEnumerable<Service> Services { get; set; }
        public IEnumerable<Skill> Skills { get; set; }
    }
}
