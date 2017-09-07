using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASPNET_Core_1_0.Models;

namespace ASPNET_Core_1_0.Controllers
{
    public class EcommerceController : Controller
    {
        public IActionResult ProductsGrid()
        {
            return View();
        }

        public IActionResult ProductsList()
        {
            return View();
        }

        public IActionResult AuthorizationList()
        {
            return View(Repository.Authorizations);
        }

        public IActionResult ProductEdit()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AuthorizationEdit(string AuthorizationNumber)
        {
            var Auth = 
                Repository.Authorizations.Where(a => a.Number == AuthorizationNumber)
                                         .First();
            return View(Auth);
        }

        [HttpPost]
        public IActionResult AuthorizationEdit(Authorization Auth)
        {
            return View(Auth);
        }

        [HttpGet]
        public ActionResult AddNewRow()
        {
            return PartialView("_RelatedFieldRow");
        }

        public IActionResult Orders()
        {
            return View();
        }

        public IActionResult ProductDetail()
        {
            return View();
        }

        public IActionResult Payments()
        {
            return View();
        }

        public IActionResult Cart()
        {
            return View();
        }
    }
}