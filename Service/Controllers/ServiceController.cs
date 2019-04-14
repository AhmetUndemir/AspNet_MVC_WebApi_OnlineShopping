using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DAL;

namespace Service.Controllers
{
    public class ServiceController : ApiController
    {
        // GET: api/Service
        public List<Product> Get()
        {
            using (ShopContext context = new ShopContext())
            {
                return null;
            }

            
        }

        // GET: api/Service/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Service
        public void Post([FromBody]string value)
        {
        }

       
    }
}
