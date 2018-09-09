using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProductWebApi.Controllers
{
    public class HotelController : ApiController
    {
        private productsEntities productsEntities = new productsEntities();

        // GET: api/Hotel
        public List<Hotel> Get()
        {
            return productsEntities.Hotels.ToList();
        }
        // POST: api/Hotel
        public void Post([FromBody]Hotel hotel)
        {
            productsEntities.Hotels.Add(hotel);
            productsEntities.SaveChanges();
        }

        // PUT: api/Hotel/5
        public void Put(int id, [FromBody]string type)
        {
            var hotel = productsEntities.Hotels.Find(id);
            
            if(type.Equals("save"))
            {
                hotel.IsSaved = "true";
            }
            else if(type.Equals("book"))
            {
                hotel.IsBooked = "true";
            }
            productsEntities.SaveChanges();
        }

        
    }
}
