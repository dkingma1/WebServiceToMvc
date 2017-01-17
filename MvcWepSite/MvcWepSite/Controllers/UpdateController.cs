using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MvcWebSiteSystem.Data.Entities;
using MvcWebSiteSystem.BLL;


namespace MvcWepSite.Controllers
{
    public class UpdateController : Controller
    { 
        // GET: Update
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult UpdateInformation(int productCode)
        {
            //if (productCode != 0)
            //{
            //    ViewBag.Message = productCode;
            //}
            //else
            //{
            //    ViewBag.Message = "Did not work";
            //}

            ProductController sysmgr = new ProductController();
            Product productInfo = sysmgr.Product_Get(productCode);
            ViewBag.ProductName = productInfo.ProductName;


            return View();
        }

        
    }
}