using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project2.Controllers
{
    public class ProductController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult NewProduct()   
        {
            return View();
        }

        [HttpPost]
        public IActionResult SaveProduct([FromForm] IFormCollection keyValues)
        {
            //todo:database save

            return RedirectToAction("newproduct", new {message="Kayıt Yapıldı", data = keyValues["name"].ToString() ,id=1});
        }

    }
}

