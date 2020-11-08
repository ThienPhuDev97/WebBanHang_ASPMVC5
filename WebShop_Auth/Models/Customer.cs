using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebShop_Auth.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        [Phone]
        public string PhoneNumber { get; set; }
        [EmailAddress(ErrorMessage = "Vui lòng nhập 1 email")]
        public string Email { get; set; }
        public virtual ICollection<Order> MyOrders { get; set; }
    }
}