using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shop.Controllers
{
    public class ShopListController : Controller
    {
        // GET: ShopList
        public ActionResult Shopping()
        {
            return View();
        }
    }
}