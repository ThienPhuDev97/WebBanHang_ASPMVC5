using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebShop_Auth.Models
{
    public class Images
    {
        public int ID { set; get; }
        public string UrlImage { get; set; }
        public int ProductID { get; set; }

        public virtual Product ProductOfImage { get; set; }
    }
}