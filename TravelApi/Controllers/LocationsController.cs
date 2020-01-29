using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore; //This is in order to use EntityState.
using TravelApi.Models;

namespace TravelApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private TravelApiContext _db;

        public LocationsController(TravelApiContext db)
        {
            _db = db;
        }

        // GET api/locations
        // THis method now allows a user to enter query parameters for species, gender and name
        // The 3 of these are properties of each Animal instance (ex: api/animals?gender=female )
        [HttpGet]
        public ActionResult<IEnumerable<Location>> Get(string city, string country, string review)
        {
            var query = _db.Locations.AsQueryable();

            if (city != null)
            {
                query = query.Where(entry => entry.City == city);
            }

            if (country != null)
            {
                query = query.Where(entry => entry.Country == country);
            }

            if (review != null)
            {
                query = query.Where(entry => entry.Review == review);
            }

            return query.ToList();
        }

        // GET api/locations/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/locations
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/locations/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/locations/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}


