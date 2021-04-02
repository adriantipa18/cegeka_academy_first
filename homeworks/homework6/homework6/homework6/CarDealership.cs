using homework6.Models;
using System.Data.Entity;

namespace homework6
{
    public class CarDealership: DbContext
    {
        public DbSet<Car> CarContext { get; set; }
        public DbSet<Customer> CustomerContext { get; set; }

        public DbSet<Customers> CustomersContext { get; set; }
        public DbSet<Inventory> InventoryContext { get; set; }

    }
}
