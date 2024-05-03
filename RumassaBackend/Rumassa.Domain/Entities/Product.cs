using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rumassa.Domain.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<string> PhotoPaths { get; set; }
        public Guid? OrderId { get; set; }
        public Guid? NewsId { get; set; }
        public virtual Order Order { get; set; }
        public virtual News News { get; set; }
        public virtual ProductDetails ProductDetails { get; set; }
        public virtual List<Category> Categories { get; set; }
        public virtual List<Review> Reviews { get; set; }
    }
}
