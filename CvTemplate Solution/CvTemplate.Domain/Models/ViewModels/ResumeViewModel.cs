using CvTemplate.Domain.Models.Entities;
using CvTemplate.Domain.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvTemplate.Domain.Models.ViewModels
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
