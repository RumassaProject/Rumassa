using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rumassa.Domain.Entities
{
    public class Cart
    {

        public int ProductId { get; set; }
        public int UserId { get; set; }
        public double TotalPrice { get; set; }
        public List<Order> Orders { get; set; }

    }
}
