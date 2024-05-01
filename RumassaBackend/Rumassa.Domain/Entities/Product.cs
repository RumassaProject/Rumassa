using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rumassa.Domain.Entities
{
    public class Product
    {

        public int ProductId { get; set; }
        public int NewsId { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public string Review { get; set; }
        public string PhotoPath { get; set; }
        public string Description { get; set; }
        public string ProductDetailId { get; set;}

    }
}
