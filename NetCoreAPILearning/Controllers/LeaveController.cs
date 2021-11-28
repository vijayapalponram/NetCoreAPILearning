using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreAPILearning.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LeaveController : ControllerBase
    {
        [HttpGet]
        public string GetLeaves()
        {
            return "Hello world1";
        }

        [HttpGet]
        [Route("single")]
        public string GetLeaveForone()
        {
            return "Hello world1";
        }


        [HttpGet]
        [Route("lastmonthleaves")]
        public string GetLasMonthLeaves()
        {
            return "Hello world1";
        }


        [HttpPost]
        public string CreateLeave()
        {
            return "Hello world2";
        }
        [HttpDelete]
        public string DeleteLeave()
        {
            return "Hello world1";
        }

        [HttpPut]
        public string UpdateLeave()
        {
            return "Hello world2";
        }
    }
}
