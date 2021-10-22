using CvTemplate.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvTemplate.Domain.Models.ViewModels
{
    public class ProjectJobCategoryViewModel
    {
        public IEnumerable<JobCategory> JobCategories { get; set; }
        public IEnumerable<Project> Projects { get; set; }
    }
}
