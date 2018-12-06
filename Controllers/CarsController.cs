using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment__3.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment__3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private Assignment__3Model db;

        public CarsController(Assignment__3Model db)
        {
            this.db = db;
        }

        [HttpGet]
        public IEnumerable<Car> Get()
        {
            return db.Cars.OrderBy(a => a.Car1).ToList();
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            Car car = db.Cars.Find(id);

            if (car == null)
            {
                return NotFound();
            }
            return Ok(car);
        }


        [HttpPost]
        public ActionResult Post([FromBody] Car car)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Cars.Add(car);
            db.SaveChanges();
            return CreatedAtAction("Post", car);
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Car car)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Entry(car).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
           Car car = db.Cars.Find(id);

            if (car == null)
            {
                return NotFound();
            }

            db.Cars.Remove(car);
            db.SaveChanges();
            return Ok();
        }
    }
}