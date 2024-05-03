using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rumassa.Domain.Entities
{
    public class ProductDetails
    {
        public Guid Id { get; set; }
        public List<string> Description { get; set; }
        public string ProductIs { get; set; }
        public string Vitamins { get; set; }
        public string Recommendation { get; set; }
        public string OnePortion { get; set; }
        public string TotalPortion { get; set; }
        public string QuantityPerPortion { get; set; }
        public string PercentPerDay { get; set; }
        public Guid? ProductId { get; set; }
        public virtual Product? Product { get; set; }
    }
}
