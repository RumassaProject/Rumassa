﻿using Rumassa.Domain.Entities.Auth;
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
        public double Price { get; set; }
        public List<string> PhotoPaths { get; set; }
        public Guid? UserId { get; set; }
        public Guid? OrderId { get; set; }
        public Guid? NewsId { get; set; }
        public Guid? CategoryId { get; set; }
        public virtual User User { get; set; }
        public virtual Order? Order { get; set; }
        public virtual News? News { get; set; }
        public virtual Category? Category { get; set; }
        public virtual List<Review> Reviews { get; set; }
    }
}
