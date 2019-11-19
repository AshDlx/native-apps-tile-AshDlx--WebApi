using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PartyAtHomes_Webapi.Repositories;

namespace PartyAtHomes_Webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private EventsRepository _eventsRepository;
        public EventsController(EventsRepository eventRepository)
        {
            _eventsRepository = eventRepository;
        }
        //check if launchUrl is correct 
        [HttpGet]
        public ActionResult<string> Get()
        {
            var h = "blah";
            return Ok(h);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok();
        }

        public async Task<IActionResult> GetById()
        {
            return Ok();
        }

    }
}