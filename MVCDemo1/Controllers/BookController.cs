using Microsoft.AspNetCore.Mvc;

namespace MVCDemo1.Controllers
{
    public class BookController : Controller
    {
        public IActionResult AddBook()
        {
            return View();
        }
    }
}
