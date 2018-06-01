using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web_Store.Models
{
    public class CartItem
    {
        [Key]
        public int CartItemId { get; set; }
        public string ArticleName { get; set; }
        public int Quantity { get; set; }
    }
}