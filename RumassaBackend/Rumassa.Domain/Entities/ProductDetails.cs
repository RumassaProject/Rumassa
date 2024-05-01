using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rumassa.Domain.Entities
{
    public class ProductDetails
    {

        public int Id { get; set; }
        public string Portion { get; set; }
        public string TotalPortion { get; set; }
        public string AmountInOnePortion { get; set; }
        public string PercenPerDay { get; set; }
    }
}
