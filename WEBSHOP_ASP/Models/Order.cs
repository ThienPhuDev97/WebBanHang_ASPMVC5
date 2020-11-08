using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WEBSHOP_ASP.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        public int ProductID { get; set; }

        public int CustomerID { get; set; }

        public virtual ICollection<Product> Products { get; set; }
        public virtual Customer Customers { get; set; }
    }
}