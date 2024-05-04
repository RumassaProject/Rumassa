using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Rumassa.Application.Abstractions;
using Rumassa.Domain.Entities;
using Rumassa.Domain.Entities.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rumassa.Infrastructure.Persistance
{
    public class RumassaDbContext : IdentityDbContext<User, IdentityRole<Guid>, Guid>, IRumassaDbContext
    {
        public RumassaDbContext(DbContextOptions<RumassaDbContext> options)
            : base(options)
        {
            Database.Migrate();
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Coupon> Coupons { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDetails> ProductDetails { get; set; }
        public DbSet<Review> Reviews { get; set; }
    }
}
