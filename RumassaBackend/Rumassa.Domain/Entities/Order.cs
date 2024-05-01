using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rumassa.Domain.Entities
{
    public class Order
    {

        public int OrderId { get; set; }
        public int UserId { get; set; }
        public DateTimeOffset OrderDate { get; set; } = DateTimeOffset.Now;
        public double TotalPrice { get; set; }
        public double OrderPrice { get; set; }
        public double DeliveryPrice { get; set; }
        public string PaymentType { get; set; }
        public int Amount { get; set; }

    }
}
