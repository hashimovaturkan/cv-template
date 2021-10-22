using CvTemplate.Domain.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvTemplate.Domain.Models.Entities
{
    public class JobCategory:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public SkillType SkillType { get; set; }

        //public virtual ICollection<Project> Projects { get; set; }
        //public virtual ICollection<Skill> Skills { get; set; }

    }

}
