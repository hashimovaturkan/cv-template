using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvTemplate.Application.Modules.Admin.BlogPostModule
{
    public class BlogPostViewModel
    { 
        public int? Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Description { get; set; }
        public DateTime? PublishedDate { get; set; }
        public string ImgUrl { get; set; }
        public int BlogCategoryId { get; set; }
    }
}
