using ClubSite.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ClubSite.Controllers
{
    [Route("api/[controller]/[action]")]
    public class AssetController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Nav()
        {
            if (!Uri.TryCreate("http://i.ytimg.com/vi/OFjlF7zQF_g/maxresdefault.jpg", UriKind.Absolute, out Uri uri)) ;
            var navImage = new Asset { Url = uri, Description = "A super great nav image" };
            return Ok(navImage);
        }
    }
}