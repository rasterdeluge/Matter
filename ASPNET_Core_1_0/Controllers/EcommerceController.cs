using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MatterCentral.Models;

namespace MatterCentral.Controllers
{
    public class EcommerceController : Controller
    {
        ///IRepository repository = Repository.Instance;


        public IActionResult ProductsGrid()
        {
            return View();
        }

        public IActionResult ProductsList()
        {
            return View();
        }

        public IActionResult FieldList()
        {
            List<string> fieldList = new List<string>{
                "ReceiveLocation", "Receiver", "ReceiverContact", "Shipper", "State", "Authorization"
            };

            return View(fieldList);
        }

        public IActionResult ProductEdit()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AuthorizationEdit(string AuthorizationNumber)
        {
            //var Auth = 
               /// Repository.Authorizations.Where(a => a.AuthorizationNumber == AuthorizationNumber)
                //                         .First();
            return View(new Authorization());
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

        [HttpGet]
        public ActionResult EditField(string Field, int Id)
        {
            // Get the correct field list, then Try to load the Field item by Id
            ///object viewModel = GetViewModel(Field, Id);
            
            string view = "EditField/_Edit" + Field;
            return PartialView(view);
        }
        //[HttpGet]
        //public ActionResult EditAuthorization(int Id)
        //{
        //    var model = new EditAuthorizationViewModel(
        //                repository.AuthorizationList.FirstOrDefault(i => i.Id == Id),
        //                repository);
        //    return PartialView("EditField/_EditAuthorization", model);
        //}
        //[HttpPost]
        //public ActionResult EditAuthorization(EditAuthorizationViewModel item)
        //{
        //    var model = new Authorization(item.Id, item.Number, item.ShipperId, item.ReceiverId, item.ReceiverContactId, item.CountyId, item.SupplierId, item.ReceiveLocationId);
        //    if (ModelState.IsValid) {
        //        return PartialView("EditField/_FieldSaved", "Authorization");
        //    }
        //    else {
        //        return PartialView("EditField/_EditAuthorization", item);
        //    }
        //}
        //[HttpGet]
        //public ActionResult ListAuthorization(int Page, int ItemsPerPage)
        //{
        //    var model = new ListAuthorizationViewModel(repository, Page, ItemsPerPage);
        //    return PartialView("EditField/_EditAuthorization", model);
        //}

        //public object GetViewModel(string Field, int Id)
        //{
        //    switch (Field) {
        //        // Compound
        //        case "Authorization":
        //            return new EditAuthorizationViewModel(
        //                repository.AuthorizationList.FirstOrDefault(i => i.Id == Id),
        //                repository);
        //        case "County":
        //            return null;
        //        case "Supplier":
        //            return null;

        //        // Singular
        //        case "ReceiveLocation":
        //            return new EditReceiveLocationViewModel(
        //                repository.ReceiveLocationList.FirstOrDefault(i => i.Id == Id));
        //        case "Receiver":
        //            return new EditReceiverViewModel(
        //                repository.ReceiverList.FirstOrDefault(i => i.Id == Id));
        //        case "ReceiverContact":
        //            return new EditReceiverContactViewModel(
        //                repository.ReceiverContactList.FirstOrDefault(i => i.Id == Id));
        //        case "Shipper":
        //            return new EditShipperViewModel(
        //                repository.ShipperList.FirstOrDefault(i => i.Id == Id));
        //        case "State":
        //            return new EditStateViewModel(
        //                repository.StateList.FirstOrDefault(i => i.Id == Id));
        //        default:
        //            return null;

        //    }
        //}
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