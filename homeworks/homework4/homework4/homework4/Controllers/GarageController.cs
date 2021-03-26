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
    public class GarageController : ControllerBase
    {
        private static List<Car> cars = new List<Car>();
        private GarageService garageService = new GarageService();
        public GarageController()
        {
            if (cars.Count == 0) 
            {
                cars.Add(new Car() { Id = 1, Brand = "Tesla", Engine = "Electric", HorsePower = 600, Model = "Model X", type = "electric" });
                cars.Add(new Car() { Id = 2, Brand = "Dacia", Engine = "1.0", HorsePower = 90, Model = "Sandero", type = "automatic" });
            }
        }

        [HttpGet]
        public IActionResult Get()
        {

            try
            {
                return Ok(cars);
            }
            catch (Exception)
            {
                return BadRequest("Something went wrong!");
            }
        }

        [HttpPost]
        public IActionResult Add(Car car)
        {
            try
            {
                garageService.AddCar(cars, car);
                return Ok("Car added!");
            }catch(Exception)
            {
                return BadRequest("Bad input, consider changing the id of the car!");

            }
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            try
            {
                if (garageService.DeleteCar(cars, id))
                {
                    return Ok("Car deleted!");
                }
                else
                {
                    return BadRequest("Car doesn't exist, check the information again!");
                }
            }
            catch (Exception)
            {
                return BadRequest("Car doesn't exist, check the information again!");
            }
        }

        [HttpPut]
        public IActionResult Update(Car car)
        {
            try
            {
                garageService.UpdateCar(cars, car);
                return Ok("Car updated!");
            }
            catch (ArgumentException e)
            {
                return BadRequest(e);
            }
        }
    }
}
