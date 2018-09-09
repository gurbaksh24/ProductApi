using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProductWebApi.Controllers
{
    public class AirController : ApiController
    {
        private productsEntities productsEntities = new productsEntities();
        // GET: api/Air
        public IEnumerable<Air> Get()
        {
            return productsEntities.Airs.ToList();
        }
        
        // POST: api/Air
        public void Post([FromBody]Air air)
        {
            productsEntities.Airs.Add(air);
            productsEntities.SaveChanges();
        }

        // PUT: api/Air/5
        public void Put(int id, [FromBody]string type)
        {
            var air = productsEntities.Airs.Find(id);

            if (type.Equals("save"))
            {
                air.IsSaved = "true";
            }
            else if (type.Equals("book"))
            {
                air.IsBooked = "true";
            }
            productsEntities.SaveChanges();
        }
        
    }
}
