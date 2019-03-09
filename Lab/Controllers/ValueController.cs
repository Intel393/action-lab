using System;
using Microsoft.AspNetCore.Mvc;

namespace Lab.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValueController : Controller
    {
        /// <summary>
        /// Get a random number value
        /// </summary>
        /// <returns>Random Number</returns>
        [HttpGet]
        public IActionResult Index()
        {
            return new JsonResult(new Random());
        }
    }
}