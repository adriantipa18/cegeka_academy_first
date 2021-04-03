using homework6.Models;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp2.Database
{
    class CarDealershipContext: DbContext
    { 

        public DbSet<Car> CarContext { get; set; }
        public DbSet<Customer> CustomerContext { get; set; }

        public DbSet<Customers> CustomersContext { get; set; }
        public DbSet<Inventory> InventoryContext { get; set; }
        
    }
}
