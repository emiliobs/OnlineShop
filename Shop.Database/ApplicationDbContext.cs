using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Shop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Database
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products{ get; set; }
        public DbSet<Order> Orders{ get; set; }
        public DbSet<OrderProduct> OrderProducts{ get; set; }
        public DbSet<Stock> Stocks{ get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<OrderProduct>().HasKey(op => new { op.ProductId, op.OrderId });

            base.OnModelCreating(builder);
        }

    }
}
