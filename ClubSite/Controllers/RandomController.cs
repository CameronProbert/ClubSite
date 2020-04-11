using ClubSite.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ClubSite.Controllers
{
    [Route("api/random/[action]")]
    public class RandomController : Controller
    {
        [HttpGet]
        public IActionResult Hello()
        {
            // return Ok("hello");
            return Unauthorized("nauuuugggghhhhtttyyyy");
        }
    }
}
