using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;

namespace OrderServices
{
    public class OrderContext : DbContext
    {
        public OrderContext() : base("OrderDataBase")
        {
            Database.SetInitializer(
                new DropCreateDatabaseIfModelChanges<OrderContext>());
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> Items { get; set; }

       // public DbSet<OrderService> Clients { get; set; }

    }
}
