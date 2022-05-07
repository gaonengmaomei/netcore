using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [Route("Get")]
        [HttpGet]
        public IActionResult Get()
        {
            var result = "success";
            return new JsonResult(result);
        }
    }
}
