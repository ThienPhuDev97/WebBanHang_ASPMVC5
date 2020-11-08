using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebShop_Auth.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public double GrandTotal { get; set; }
        public string IncrementID { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int Status { get; set; }
        public virtual Customer Cusomer { get; set; }
        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
    }
}