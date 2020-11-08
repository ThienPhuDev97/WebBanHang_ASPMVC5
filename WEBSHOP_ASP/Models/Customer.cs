using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WEBSHOP_ASP.Models
{
	public class Customer
	{
		[Key]
		public int CustomerID { get; set; }
		public string CustomerName { get; set; }

		public virtual ICollection<Order> Orders { get; set; }
	}
}