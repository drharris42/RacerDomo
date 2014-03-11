using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RD.Entities;

namespace RacerDomo.Controllers
{
    public class EventController : ApiController
    {
        // GET api/event
        public IHttpActionResult Get()
        {
            var testEvent = new FEvent();

            return Json(testEvent);
        }

        // GET api/event/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/event
        public void Post([FromBody]string value)
        {
        }

        // PUT api/event/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/event/5
        public void Delete(int id)
        {
        }
    }
}
