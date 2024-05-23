using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR_WebUI.Dtos.ContactDtos
{
    public class UpdateContactDto
    {
        public int ContactID { get; set; }
        public string FooterLocation { get; set; }
        public string FooterPhone { get; set; }
        public string FootertEmail { get; set; }
        public string FooterDescription { get; set; }
    }
}
