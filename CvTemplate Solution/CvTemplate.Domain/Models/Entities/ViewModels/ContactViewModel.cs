using Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvTemplate.Domain.Models.Entities.ViewModels
{
    public class ContactViewModel
    {
        public string Location { get; set; }
        public string Phone { get; set; }
        public string MainEmail { get; set; }
        public ContactPost ContactPost { get; set; }

        [Display(ResourceType = typeof(ContactResource), Name = "Name")]
        [Required(ErrorMessageResourceType = typeof(ContactResource), ErrorMessageResourceName = "CantBeEmpty")]
        public string Name { get; set; }

        [Display(ResourceType = typeof(ContactResource), Name = "Email")]
        [Required(ErrorMessageResourceType = typeof(ContactResource), ErrorMessageResourceName = "CantBeEmpty")]
        [EmailAddress(ErrorMessageResourceType = typeof(ContactResource), ErrorMessageResourceName = "InvalidEmailAddress")]
        public string Email { get; set; }

        [Display(ResourceType = typeof(ContactResource), Name = "Content")]
        [Required(ErrorMessageResourceType = typeof(ContactResource), ErrorMessageResourceName = "CantBeEmpty")]
        public string Comment { get; set; }
    }
}
