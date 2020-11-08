using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebShop_Auth.Models
{
    public class CartItem
    {
        public CartItem(Product product,int quantity)
        {
            Quantity = quantity;
            Product = product;
        }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public double Total { get => Quantity * Product.Price;}
    }
}