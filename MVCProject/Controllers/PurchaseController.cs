using Microsoft.AspNetCore.Mvc;

namespace MVCProject.Controllers
{
    public class PurchaseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
