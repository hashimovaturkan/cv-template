using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvTemplate.Application.Modules.Admin.AttachmentModule
{
    public class AttachmentViewModel
    {
        public int? Id { get; set; }
        public string AttachmentUrl { get; set; }
        public string Name { get; set; }
        public string IconUrl { get; set; }
        public IFormFile AttachmentFile { get; set; }
        public IFormFile IconFile { get; set; }
        public string fileTemp1 { get; set; }
        public string fileTemp2 { get; set; }
    }
}
