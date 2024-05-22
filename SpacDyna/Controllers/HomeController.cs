using Microsoft.AspNetCore.Mvc;

namespace SpacDyna.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
