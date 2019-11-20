using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PartyAtHomes_Lib;
using PartyAtHomes_WebApi.Repositories;

namespace PartyAtHomes_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private EventRepository _eventRepository;
        public EventsController(EventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }
        //webapi check => check if the start Url is set correctly in launchSettings
        [HttpGet]
        public async Task<IActionResult> get()
        {
            var h = "hello";
            return Ok(h);
        }

        [HttpGet("All")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _eventRepository.GetAll());
        }

        [HttpGet("id/{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await _eventRepository.GetById(id));
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create(Event even, User user)
        {
            return Ok(await _eventRepository.Create(even, user));
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update(Event even, User user)
        {
            return Ok(await _eventRepository.Update(even, user));
        }
    }
}