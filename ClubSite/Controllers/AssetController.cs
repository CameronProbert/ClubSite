using ClubSite.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ClubSite.Controllers
{
    [Route("api/auth/[action]")]
    public class AuthController : Controller
    {
        [HttpPost]
        public async Task<IActionResult> Login([FromBody]Credentials request)
        {
            var authUser = new AuthUser("success", "38595847A485DJSHND94857", request?.userName);
            return Ok(authUser);
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            return Ok();
        }
    }
}