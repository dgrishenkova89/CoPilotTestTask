using CoPilot.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CoPilot.App.Controllers
{
    public class BooksController : Controller
    {
        private readonly IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
