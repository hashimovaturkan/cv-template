using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvTemplate.Application.Modules.Admin.SocialProfileModule
{
    public class SocialProfileViewModel
    {
        public int? Id { get; set; }
        public string IconFileUrl { get; set; }
        public string IconUrl { get; set; }
        public IFormFile file { get; set; }
        public string fileTemp { get; set; }
    }
}
