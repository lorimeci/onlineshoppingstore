using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace onlineshoppingstore.Models
{
    public class ShoppingStoreEntities : DbContext
    {
        /*ktu jan rujt klasat e dbseteve*/
        /*DbSet i tregon klases Item per te perfaqesuar nje
         * rrjesht ne tabelen Item*/
        public DbSet<Item> Items { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        

    }

}