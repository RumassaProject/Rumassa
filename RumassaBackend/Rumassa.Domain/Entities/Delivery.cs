using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rumassa.Domain.Entities
{
    public class Delivery
    {

        public int Id { get; set; }
        public string FISH { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string City { get; set; }
        public string MailIndex { get; set; }
        public string St_Address { get; set; }
        public string Details { get; set; }

    }
}
