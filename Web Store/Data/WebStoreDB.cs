using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Web_Store.Models;

namespace Web_Store.Data
{
    public class WebStoreDB : DbContext
    {
        public WebStoreDB() : base("DefaultConnection") { }
        
        public DbSet<Product> Products { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}