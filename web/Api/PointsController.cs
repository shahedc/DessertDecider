using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using web.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace web.Api
{
    [Route("api/[controller]")]
    public class PointsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PointsController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: api/values
        [HttpGet]
        public int Get()
        {
            var totalPoints = _context.DessertItems.Sum(i => Convert.ToInt32(i.Points));

            return totalPoints;
            //return new string[] { "value1", "value2" };
        }

        //// GET api/values/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/values
        //[HttpPost]
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
