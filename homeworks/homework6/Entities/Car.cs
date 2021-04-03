using ConsoleApp2.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;

namespace homework6.Models
{
    public class Car : IEntity
    {
        public Guid Id { get; set; }
        [Required]
        public string Brand { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public string TypeOfCar { get; set; }
        [Required]
        public double Engine { get; set; }
        public int HorsePower { get; set; }
        public bool HasElectricWindows { get; set; }
        public bool HasNavigation { get; set; }

    }
}
