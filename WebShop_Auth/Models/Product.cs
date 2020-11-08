using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebGrease.ImageAssemble;

namespace WebShop_Auth.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int Qty { get; set; }
        public string ImageProduct { set; get; }
        public int CategoryID { get; set; }
        public int BrandID { get; set; }
        public virtual Category CategoryOfProduct { get; set; }
        public virtual Brand BrandOfProduct { get; set; }
        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
        public virtual ICollection<Images> Images { get; set; }
    }
}