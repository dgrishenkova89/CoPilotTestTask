using CoPilot.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CoPilot.App.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
