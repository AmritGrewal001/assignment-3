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
    public class BikesController : ControllerBase
    {
        private Assignment__3Model db;

        public BikesController(Assignment__3Model db)
        {
            this.db = db;
        }

        [HttpGet]
        public IEnumerable<Bike> Get()
        {
            return db.Bikes.OrderBy(a => a.Bike1).ToList();
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            Bike bike = db.Bikes.Find(id);

            if (bike == null)
            {
                return NotFound();
            }
            return Ok(bike);
        }
//commit
        
        [HttpPost]
        public ActionResult Post([FromBody] Bike bike)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Bikes.Add(bike);
            db.SaveChanges();
            return CreatedAtAction("Post", bike);
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Bike bike)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Entry(bike).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            Bike bike = db.Bikes.Find(id);

            if (bike == null)
            {
                return NotFound();
            }

            db.Bikes.Remove(bike);
            db.SaveChanges();
            return Ok();
        }
    }
}
