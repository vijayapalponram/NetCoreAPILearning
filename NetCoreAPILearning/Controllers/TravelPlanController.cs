using Microsoft.AspNetCore.Mvc;
using NetCoreAPILearning.Models;
using NetCoreAPILearning.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NetCoreAPILearning.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TravelPlanController : ControllerBase
    {
        private ITravelPlan travelPlan;

        public TravelPlanController(ITravelPlan _travelPlan)
        {
            travelPlan = _travelPlan;
        }

        [HttpGet]
        public IEnumerable<Travel> Get()
        {
            return travelPlan.GetTravelPlans(); 
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            if (id == "0")
            {
                return BadRequest();
            }
            Travel travel = travelPlan.GetTravelPlanById(id);
            if(travel == null)
            {
                return NotFound();
            }
            return Ok(travel);
        }

    }
}
