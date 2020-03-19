using Microsoft.AspNetCore.Mvc;

namespace MusicCollection.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }
    }
}

