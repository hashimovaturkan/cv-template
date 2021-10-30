using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvTemplate.Application.Modules.Admin.ProjectModule
{
    public class ProjectViewModel
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public int JobCategoryId { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
        public IFormFile file { get; set; }
        public string fileTemp { get; set; }
    }
}
