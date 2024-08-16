using Microsoft.AspNetCore.Mvc;

namespace MVCProject.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
