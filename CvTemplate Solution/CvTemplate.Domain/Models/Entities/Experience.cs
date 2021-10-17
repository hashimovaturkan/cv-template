using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvTemplate.Domain.Models.Entities
{
    public class Experience:BaseEntity
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Job { get; set; }
        public string Company { get; set; }
        public string Details { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime EndingDate { get; set; }
        public string ImageUrl { get; set; }
    }
}
