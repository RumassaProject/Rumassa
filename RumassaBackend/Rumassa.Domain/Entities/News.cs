using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rumassa.Domain.Entities
{
    public class News
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public string PhotoPath { get; set; }
        public string Author { get; set;}
        public DateTimeOffset Date { get; set; }= DateTimeOffset.Now;
        public string Description { get; set; }
        public List<Product> Products  { get; set; }
    }
}
