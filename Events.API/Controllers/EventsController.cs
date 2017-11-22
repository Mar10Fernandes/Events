using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Events.Domain.Entities;
using Events.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Events.API.Controllers
{
    [Route("api/[controller]")]
    public class EventsController : Controller
    {
        private IEventsDomain _eventsDomain;

        EventsController(IEventsDomain eventsDomain)
        {
            this._eventsDomain = eventsDomain;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Event> Get()
        {
            return _eventsDomain.FindAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
