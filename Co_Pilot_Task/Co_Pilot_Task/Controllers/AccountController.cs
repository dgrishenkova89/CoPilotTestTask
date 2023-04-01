using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Google;
using CoPilot.Services.Interfaces;

namespace CoPilot.App.Controllers
{
    [Route("[controller]")]
    public class AccountController : Controller
    {
        private readonly IUserService _userService;
        private readonly ILogger _logger;

        public AccountController(IUserService userService, ILogger<AccountController> logger)
        {
            _logger = logger;
            _userService = userService;
        }

        [HttpPost]
        [Route("logout")]
        public async Task<IActionResult> Logout()
        {
            _logger.LogInformation("User {Name} logged out at {Time}.",
                User.Identity.Name, DateTime.UtcNow);

            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            await HttpContext.SignOutAsync(GoogleDefaults.AuthenticationScheme);


            return RedirectToPage("/Account/SignedOut");
        }
    }
}