using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProductWebApi.Controllers
{
    public class AcitivitiesController : ApiController
    {
        private productsEntities productsEntities = new productsEntities();
        // GET: api/Acitivities
        public IEnumerable<Activity> Get()
        {
            return productsEntities.Activities.ToList();
        }
        

        // POST: api/Acitivities
        public void Post([FromBody]Activity activity)
        {
            productsEntities.Activities.Add(activity);
            productsEntities.SaveChanges();
        }

        // PUT: api/Acitivities/5
        public void Put(int id, [FromBody]string type)
        {
            var activity = productsEntities.Activities.Find(id);

            if (type.Equals("save"))
            {
                activity.IsSaved = "true";
            }
            else if (type.Equals("book"))
            {
                activity.IsBooked = "true";
            }
            productsEntities.SaveChanges();
        }
        
    }
}
