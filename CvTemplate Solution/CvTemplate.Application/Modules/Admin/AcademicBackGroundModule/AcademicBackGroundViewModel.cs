using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvTemplate.Application.Modules.Admin.AcademicBackGroundModule
{
    public class AcademicBackGroundViewModel
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Degree { get; set; }
        public string Qualification { get; set; }
        public string University { get; set; }
        public string Details { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime EndingDate { get; set; }
        public string ImageUrl { get; set; }
        public IFormFile file { get; set; }
        public string fileTemp { get; set; }
    }
}
