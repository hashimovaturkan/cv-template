using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvTemplate.Domain.Models.Entities.Enums
{
    public enum SkillType
    {
        [Display(Name = "Hard Skills")]
        HardSkills = 0,
        [Display(Name = "Soft Skills")]
        SoftSkills =1
    }
}
