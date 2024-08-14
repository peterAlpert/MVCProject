using Microsoft.AspNetCore.Mvc;
using MVCProject.Interfaces;
using MVCProject.Models;

namespace MVCProject.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
