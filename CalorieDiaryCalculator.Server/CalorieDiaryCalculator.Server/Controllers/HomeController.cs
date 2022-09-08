using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CalorieDiaryCalculator.Server.Controllers {
    [ApiController]
    public class HomeController : ControllerBase {
        //[Authorize]
        [Route("[controller]")]
        public IActionResult Get() {
            return Ok("Works!!!");
        }
    }
}