using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebShop_Auth.Models;

namespace WebShop_Auth.DataConnect
{
    public class DataContext: DbContext
    {
       public DataContext() : base("WebShopDB")
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderProduct> orderProducts { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<UserCart> UserCarts { get; set; }

        public DbSet<Images> Images { get; set; }
    }
}