using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRWebUI.Dtos.ContactDtos
{
    public class ResultContactDto
    {
        public int ContactID { get; set; }
        public string Location { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string FooterTitle { get; set; } //footer'ın başlığı
        public string FooterDescription { get; set; } //footer'ın açıklaması
        public string OpenDays { get; set; } //footer'ın açıklaması
        public string OpenDaysDescription { get; set; } //footer'ın açıklaması
        public string OpenHours { get; set; } //footer'ın açıklaması

    }
}
