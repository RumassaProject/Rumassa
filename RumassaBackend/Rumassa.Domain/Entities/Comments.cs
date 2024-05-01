using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rumassa.Domain.Entities
{
    public class Comments
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string TelegramLogin { get; set; }
        public string CommentText { get; set;}

    }
}
