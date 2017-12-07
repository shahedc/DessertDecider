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
    public class DecideController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DecideController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: api/values
        [HttpGet]
        public bool Get()
        {
            var totalPoints = _context.DessertItems.Sum(i => Convert.ToInt32(i.Points));

            if (totalPoints >= Utils.DessertUtils.MaxPoints)
                return false;
            else
                return true;
            
        }

    }
}
