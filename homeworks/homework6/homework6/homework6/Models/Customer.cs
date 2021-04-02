using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace homework6.Models
{
    public class Customer
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; }
        public List<Car> CarsBought { get; set; }
        public Car InterestedInCar { get; set; }
    }
}
