﻿using CvTemplate.Domain.Models.Entities.Membership;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvTemplate.Domain.Models.Entities
{
    public class BlogPostComment : BaseEntity
    {
        public string Comment { get; set; }
        public int BlogPostId { get; set; }
        public virtual BlogPost BlogPost { get; set; }
        public int? ParentId { get; set; }
        public virtual BlogPostComment Parent { get; set; }
        public virtual ICollection<BlogPostComment> Children { get; set; }
        public virtual CvTemplateUser CreatedByUser { get; set; }
    }
}
