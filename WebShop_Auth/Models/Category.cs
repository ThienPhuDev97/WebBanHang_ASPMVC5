using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebShop_Auth.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập tên Danh mục")]
        public string CategoryName { get; set; }
        public string CategoryIcon { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}