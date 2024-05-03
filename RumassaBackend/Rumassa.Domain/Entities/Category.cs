using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rumassa.Domain.Entities
{
    public class Category
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid? ProductId { get; set; }
        public Guid? CatalogId { get; set; }
        public virtual Product Product { get; set; }
        public virtual Catalog Catalog { get; set; }
    }
}
