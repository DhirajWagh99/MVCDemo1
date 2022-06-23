
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Web;

namespace MVCDemo1.Controllers
{
    public class EmployeeController : Controller
    {
        [HttpGet]
        public IActionResult EmployeeDetails()
        {
            
            
                List<string> Options = new List<string>();
                Options.Add("Choose an Option");
                Options.Add("Yes");
                Options.Add("No");
                ViewData["Options"] = new SelectList(Options);
                return View();
            

           
        }
        [HttpPost]
        public ActionResult EmployeeDetails(IFormCollection fc, ICollection<string> Department)
        {
            ViewBag.firstname = fc["firstname"];
            ViewBag.lastname = fc["lastname"];
            ViewBag.phone = fc["phone"];
            ViewBag.gender = fc["Gender"];
            ViewBag.Department = Department;
            ViewBag.options = fc["Option"];
            return View("Details");
        }
    }
}
