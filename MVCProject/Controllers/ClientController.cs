using Microsoft.AspNetCore.Mvc;

namespace MVCProject.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
