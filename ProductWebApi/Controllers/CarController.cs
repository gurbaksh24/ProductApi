using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProductWebApi.Controllers
{
    public class CarController : ApiController
    {
        private productsEntities productsEntities = new productsEntities();
        // GET: api/Car
        public IEnumerable<Car> Get()
        {
            return productsEntities.Cars.ToList();
        }
        
        // POST: api/Car
        public void Post([FromBody]Car car)
        {
            productsEntities.Cars.Add(car);
            productsEntities.SaveChanges();
        }

        // PUT: api/Car/5
        public void Put(int id, [FromBody]string type)
        {
            var car = productsEntities.Cars.Find(id);

            if (type.Equals("save"))
            {
                car.IsSaved = "true";
            }
            else if (type.Equals("book"))
            {
                car.IsBooked = "true";
            }
            productsEntities.SaveChanges();
        }
        
    }
}
