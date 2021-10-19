using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvTemplate.Domain.Models.Entities
{
    public class Bio:BaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
