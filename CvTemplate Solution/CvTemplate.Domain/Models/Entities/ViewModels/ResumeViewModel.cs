using CvTemplate.Domain.Models.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvTemplate.Domain.Models.Entities.ViewModels
{
    public class ResumeViewModel
    {
        public IEnumerable<AcademicBackGround> AcademicBackGrounds { get; set; }
        public IEnumerable<Experience> Experiences { get; set; }
        public IEnumerable<Skill> Skills { get; set; }
        public IEnumerable<JobCategory> JobCategories { get; set; }
        public Bio Bio { get; set; }

    }
}
