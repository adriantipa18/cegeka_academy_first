using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace homework6.Models
{
    public class Inventory
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public List<Car> CarsAvailable { get; set; }
    }
}
