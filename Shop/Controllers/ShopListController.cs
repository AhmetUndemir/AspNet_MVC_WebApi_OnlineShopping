using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Shop.Controllers
{
    public class ShopListController : Controller
    {
        // GET: ShopList
        public async Task<ActionResult> Shopping()
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync("http://localhost:59396/api/Service");

                return View();
            }

            
        }
    }
}