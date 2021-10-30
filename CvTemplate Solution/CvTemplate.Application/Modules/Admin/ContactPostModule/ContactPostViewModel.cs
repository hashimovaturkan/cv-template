using CvTemplate.Domain.Models.Entities;
using CvTemplate.Domain.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvTemplate.Application.Modules.Admin.ContactPostModule
{
    public class ContactPostViewModel
    {
        public int InboxCount { get; set; }
        public int UnreadCount { get; set; }
        public int SentCount { get; set; }
        public PagedViewModel<ContactPost> ContactPagedViewModel { get; set; }
    }
}
