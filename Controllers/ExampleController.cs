using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CoustmerApp.Models;

namespace CoustmerApp.Controllers
{
    public class ExampleController : Controller
    {
        public ViewResult AllCoustomer()
        {
            var context = new AssesmentEntities();
            var model = context.CustTables.ToList();
            return View(model);
        }
        public ViewResult Find(string id)
        {
            int custID = int.Parse(id);
            var context = new AssesmentEntities();
            var model = context.CustTables.FirstOrDefault((e) => e.CustID == custID);
            return View(model);
        }
        [HttpPost]
        public ActionResult Find(CustTable cst)
        {
            var context = new AssesmentEntities();
            var model = context.CustTables.FirstOrDefault((e) => e.CustID == cst.CustID);
            model.CustName = cst.CustName;
            model.CustAddress = cst.CustAddress;
            context.SaveChanges();
            return RedirectToAction(" AllCoustomer");
        }

        public ViewResult NewCustomer()
        {
            var model = new CustTable();
            return View(model);
        }
        [HttpPost]
        public ActionResult NewCustomer(CustTable cst)
        {
            var context = new AssesmentEntities();
            context.CustTables.Add(cst);
            context.SaveChanges();
            return RedirectToAction("AllCoustomer");
        }


    }
}