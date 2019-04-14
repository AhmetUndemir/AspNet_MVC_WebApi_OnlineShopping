﻿using DAL.Model;
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
                return context.Product.ToList();
            }


        }

        // GET: api/Service/5
        public Product Get(int id)
        {
            using (ShopContext context = new ShopContext())
            {
                return context.Product.FirstOrDefault(x => x.id == id);
            }
        }

        // POST: api/Service
        public void Post([FromBody]string value)
        {
        }


    }
}
