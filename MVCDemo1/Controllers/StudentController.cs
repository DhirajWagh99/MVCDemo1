using Microsoft.AspNetCore.Mvc;
using MVCDemo1.Models;

namespace MVCDemo1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult AddStudent ()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddStudent( Student student)
        { return View();}
    }
}
