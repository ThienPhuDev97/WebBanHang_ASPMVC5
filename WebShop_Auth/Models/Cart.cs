using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls.Expressions;

namespace WebShop_Auth.Models
{
    //doi tuong gio hang
    public class Cart
    {
        public List<CartItem> _cartItems;
        public double _grandTotal;

        public Cart()
        {
            _cartItems = new List<CartItem>();
        }
        public CartItem this[int index]
        {
            get => CartItems[index];
            set => CartItems[index] = value;
        }
        public List<CartItem> CartItems { get => _cartItems; }
        public double GrandTotal { get => _grandTotal; set => _grandTotal = value; }
        public bool AddtoCart(CartItem item)
        {
            try
            {
                int check = CheckExists(item);
                if (check >= 0)
                    CartItems[check].Quantity += item.Quantity;
                else
                    CartItems.Add(item);
                CalculateGrandTotal();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public void CalculateGrandTotal()
        {
            double grandTotal = 0;
            foreach(CartItem item in CartItems)
            {
                grandTotal += item.Product.Price * item.Quantity;
            }
            GrandTotal = grandTotal;
        }
        //kiem tra xem product co ton tai trong gio hang ko
        public int CheckExists(CartItem item)
        {
            for (int i = 0; i < CartItems.Count; i++)
            {
                if (CartItems[i].Product.Id == item.Product.Id)
                {
                    return i;
                }
            }
            return -1;
        }

    }
}