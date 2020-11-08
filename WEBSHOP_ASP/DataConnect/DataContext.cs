using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WEBSHOP_ASP.Models;

namespace WEBSHOP_ASP.DataConnect
{
    public class DataContext: DbContext
    {
       public DataContext() : base("WebShopEntities")
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}