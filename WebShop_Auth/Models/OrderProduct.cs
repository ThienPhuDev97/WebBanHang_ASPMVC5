using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebShop_Auth.Models
{
    public class OrderProduct
    {

        public int Id { get; set; }
        public int Qty { get; set; }
        public double Price { get; set; }
        public int Order_Id { get; set; }
        public int Product_Id { get; set; }
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}