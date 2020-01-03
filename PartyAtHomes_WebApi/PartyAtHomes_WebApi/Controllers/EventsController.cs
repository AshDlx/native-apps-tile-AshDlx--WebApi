using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PartyAtHomes_Lib;
using PartyAtHomes_WebApi.Repositories;
using PartyAtHomes_WebApi.Services;

namespace PartyAtHomes_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private EventRepository _eventRepository;
        private ValidationService _validationService;
        public EventsController(EventRepository eventRepository, ValidationService validationService)
        {
            _eventRepository = eventRepository;
            _validationService = validationService;
        }
        //webapi check => check if the start Url is set correctly in launchSettings
        [HttpGet]
        public IActionResult get()
        {
            var h = "hello";
            return Ok(h);
        }

        [HttpGet("All")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _eventRepository.GetAllDto());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(long id)
        {
            return Ok(await _eventRepository.GetById(id));
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create(EventCRUDDto eventDto)
        {
            return Ok(await _eventRepository.Create(eventDto));
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update(EventCRUDDto eventDto)
        {
            return Ok(await _eventRepository.Update(eventDto));
        }

        [HttpGet("User/{id}")]
        public async Task<IActionResult> GetEventsByUser(Guid id)
        {
            return Ok(await _eventRepository.GetEventsByUser(id));
        }

        [HttpPost]
        [Route("Image")]
        public async Task<IActionResult> Image([FromForm(Name = "file")]IFormFile formFile)
        {
            if (formFile == null)
            {
                Console.Write("formfile is leeg");
            }
            var filePath = Path.Combine(Directory.GetCurrentDirectory(),
            "wwwroot", "images", formFile.FileName);
            if (formFile.Length > 0)
            {
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await formFile.CopyToAsync(stream);
                }
            }
            return Ok("Succes");
        }
    }
}