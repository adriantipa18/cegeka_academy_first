using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace homework6.Models
{
    public class Customers
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public List<Customer> AllCustomers { get; set; }

    }
}
