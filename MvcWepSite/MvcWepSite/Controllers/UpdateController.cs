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
            ProductController sysmgr = new ProductController();
            Product productInfo = sysmgr.Product_Get(productCode);
            ViewBag.ProductName = productInfo.ProductName;
            ViewBag.UnitPrice = productInfo.UnitPrice;
            ViewBag.QuantityOnHand = productInfo.UnitsInStock;
            ViewBag.productCode = productCode;

            return View();
        }

        public ActionResult UpdateProduct(string ProductName, int productCode, short QuantityOnHand, int UnitPrice)
        {
            ProductController sysmgr = new ProductController();
            Product productInfo = sysmgr.Product_Get(productCode);
            productInfo.ProductName = ProductName;
            productInfo.UnitsInStock = QuantityOnHand;
            productInfo.UnitPrice = UnitPrice;
            productInfo.ProductID = productCode;
            sysmgr.Product_Update(productInfo);

            return View();
        }



    }
}