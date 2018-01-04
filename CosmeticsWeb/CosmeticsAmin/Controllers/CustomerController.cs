using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CosmeticsShare.Customers;
using NLog;

namespace CosmeticsAmin.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        private static Logger _logger = LogManager.GetCurrentClassLogger();
        public ActionResult Index()
        {
            CustomersViewModels model = new CustomersViewModels();
            return View(model);
        }
        public ActionResult Search(CustomersViewModels model)
        {
            try
            {
                
            }
            catch (Exception e)
            {
                _logger.Error("Customers_Search: " + e);
                return new HttpStatusCodeResult(400, e.Message);
            }
            return PartialView("_ListData", model);
        }

    }
}