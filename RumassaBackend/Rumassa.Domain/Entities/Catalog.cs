﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rumassa.Domain.Entities
{
    public class Catalog
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public virtual List<Category> Categories { get; set; }
    }
}
