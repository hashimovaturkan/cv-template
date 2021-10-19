using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvTemplate.Domain.Models.Entities
{
    public class Project:BaseEntity
    {
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public int JobCategoryId { get; set; }
        public virtual JobCategory JobCategory { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
    }
}
