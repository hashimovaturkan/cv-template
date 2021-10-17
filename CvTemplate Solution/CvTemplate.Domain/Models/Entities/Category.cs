using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvTemplate.Domain.Models.Entities
{
    public class Category:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        //public virtual ICollection<Project> Projects { get; set; }
        //public virtual ICollection<Skill> Skills { get; set; }

    }

    //hansi?
    //enum Category
    //{

    //}

    //birdeki skilldeki categori portoliodaki categoru eynidi?
}
