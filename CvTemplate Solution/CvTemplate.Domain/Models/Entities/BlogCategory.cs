using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvTemplate.Domain.Models.Entities
{
    public class BlogCategory:BaseEntity
    {
        public string Name { get; set; }
        public int? OrderBy { get; set; } = 0;
    }
}
