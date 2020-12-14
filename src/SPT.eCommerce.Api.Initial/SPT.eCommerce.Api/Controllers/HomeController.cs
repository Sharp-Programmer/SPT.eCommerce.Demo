using Microsoft.AspNetCore.Mvc;

namespace SPT.eCommerce.Api.Controllers
{
    /// <summary>
    /// Home Controller
    /// </summary>
    [Route("")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        /// <summary>
        /// API Home page to display our API project is running
        /// </summary>
        /// <returns>Returns message and swagger documentation url</returns>
        [HttpGet("")]
        public IActionResult Get()
        {
            return Ok(new {
                message = "Sharp Programmer Tutorials - eCommerce Sample project is running!",
                tryIt = $"{Request.Scheme}://{Request.Host}/docs/index.html"
            }); ;
        }
    }
}
