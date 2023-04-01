using CoPilot.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CoPilot.App.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
