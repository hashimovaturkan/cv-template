using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvTemplate.Domain.Models.Entities
{
    public class Attachment:BaseEntity
    {
        //bir setirde elave ele uje onda uploadsa her defe file elave eliyessen onun urlini saxla(admin terefde file add etme)
        public string AttachmentUrl { get; set; }
        public string Name { get; set; }
        public string IconUrl { get; set; }

    }
}
