﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rumassa.Domain.Entities
{
    public class Review
    {

        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Content { get; set;}
    }
}
