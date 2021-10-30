using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace CvTemplate.Application.Modules.Admin.ExperienceModule
{
    public class ExperienceViewModel
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Job { get; set; }
        public string Company { get; set; }
        public string Details { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime EndingDate { get; set; }
        public string ImageUrl { get; set; }
        public IFormFile file { get; set; }
        public string fileTemp { get; set; }
    }
}
