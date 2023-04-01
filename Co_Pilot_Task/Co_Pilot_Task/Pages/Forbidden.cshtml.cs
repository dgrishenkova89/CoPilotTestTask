using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoPilot.App.Pages
{
    public class ForbiddenModel : PageModel
    {
        public string Message { get; private set; }

        public void OnGet()
        {
            Message = "Forbidden page.";
        }
    }
}
