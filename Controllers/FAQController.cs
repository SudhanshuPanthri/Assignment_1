using Microsoft.AspNetCore.Mvc;

namespace Assignment__1.Controllers
{
    public class FAQ : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
