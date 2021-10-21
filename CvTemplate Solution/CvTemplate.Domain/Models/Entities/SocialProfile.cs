using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvTemplate.Domain.Models.Entities
{
    public class SocialProfile:BaseEntity
    {
        //lowercase kimi saxla dbde
        public string Name { get; set; }
        public string IconUrl { get; set; }
    }
}
