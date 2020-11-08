using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WEBSHOP_ASP.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Qty { get; set; }
        public int Price { get; set; }
        public int CategoryID { get; set; }
        public int BrandID { get; set; }

        public virtual Category CategoryProduct { get; set; }
        public virtual Brand Brands { get; set; }
    }
}