using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using MVCDemo1.Models;


namespace MVCDemo1.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult GetAllProducts()
        {
            List<Product> productlist = new List<Product>()
            {
                new Product { Id = 1, Name = "Laptop", Company = "Dell", Price = 320000 },
                new Product { Id = 2, Name = "Laptop", Company = "HP", Price = 380000 },
                new Product { Id = 3, Name = "Laptop", Company = "Lenovo", Price = 450000 },
                new Product { Id = 4, Name = "Laptop", Company = "Acer", Price = 325000 },
            };
            ViewBag.ProductList = productlist;
            return View();
        }
        public ActionResult AddNew()
        {
            return View();
        }
        public ActionResult ModifyProduct()
        {
            return View();
        }
        public ActionResult DeleteProduct()
        {
            return View();
        }
    }
}
