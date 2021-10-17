using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvTemplate.Domain.Models.Entities
{
    public class AcademicBackGround:BaseEntity
    {
        public string Name { get; set; }
        public string Degree { get; set; }
        public string Qualification { get; set; }
        public string University { get; set; }
        public string Details { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime EndingDate { get; set; }
        public string ImageUrl { get; set; }
    }
}
