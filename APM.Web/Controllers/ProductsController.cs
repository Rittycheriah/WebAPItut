using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using APM.Web.Models;

namespace APM.Web.Controllers
{
    public class ProductsController : ApiController
    {
        // GET: api/Products
        public IEnumerable<Product> Get()
        {
            var ProductRepository = new ProductRepository();
            return ProductRepository.Retrieve();
        }

        // GET: api/Products/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Products
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Products/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Products/5
        public void Delete(int id)
        {
        }
    }
}
