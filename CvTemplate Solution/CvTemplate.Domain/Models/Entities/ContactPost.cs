using Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvTemplate.Domain.Models.Entities
{
    public class ContactPost:BaseEntity
    {
        //[Display(ResourceType = typeof(ContactResource), Name = "Name")]
        //[Required(ErrorMessageResourceType = typeof(ContactResource), ErrorMessageResourceName = "CantBeEmpty")]
        public string Name { get; set; }

        //[Display(ResourceType = typeof(ContactResource), Name = "Email")]
        //[Required(ErrorMessageResourceType = typeof(ContactResource), ErrorMessageResourceName = "CantBeEmpty")]
        //[EmailAddress(ErrorMessageResourceType = typeof(ContactResource), ErrorMessageResourceName = "InvalidEmailAddress")]
        public string Email { get; set; }

        //[Display(ResourceType = typeof(ContactResource), Name = "Content")]
        //[Required(ErrorMessageResourceType = typeof(ContactResource), ErrorMessageResourceName = "CantBeEmpty")]
        public string Comment { get; set; }
        public string Answer { get; set; }
        public DateTime? AnswerDate { get; set; }
        public int? AnswerByUserId { get; set; }
    }
}
