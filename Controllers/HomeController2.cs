using Microsoft.AspNetCore.Mvc;

namespace Student_app.Controllers
{
    public class HomeController2 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
