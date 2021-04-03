using homework4.Models;
using homework4.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace homework4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DealershipController : ControllerBase
    {
        private static List<Customer> customers = new List<Customer>();
        private DealershipService dealershipService = new DealershipService();

        public DealershipController()
        {
            if (customers.Count == 0)
            {
                List<Car> tempCarList = new List<Car>();
                tempCarList.Add(new Car() { Id = 1, Brand = "Tesla", Engine = "Electric", HorsePower = 600, Model = "Model X", type = "electric" });
                tempCarList.Add(new Car() { Id = 2, Brand = "Dacia", Engine = "1.0", HorsePower = 90, Model = "Sandero", type = "automatic" });
                customers.Add(new Customer() { Id = 1, FirstName = "Andrei", LastName = "andrei", CarsOwned = tempCarList });
            }
        }

        [HttpGet]
        public IActionResult Get()
        {

            try
            {
                return Ok(customers);
            }
            catch (Exception)
            {
                return BadRequest("Something went wrong!");
            }
        }
    }
}
