using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvTemplate.Domain.Models.Entities
{
    public class Skill:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int? Level { get; set; }
        public bool IsBar { get; set; }
        public int? CategoryId { get; set; }
        public virtual Category Category { get; set; }


    }
}
