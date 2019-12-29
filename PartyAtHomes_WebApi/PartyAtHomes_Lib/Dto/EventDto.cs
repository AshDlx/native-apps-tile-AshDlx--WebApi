using Microsoft.AspNetCore.Http;
using System;

namespace PartyAtHomes_Lib
{
    public class EventDto
    {
        public long Id { get; set; }
        public string EventName { get; set; }
        public string MainImage { get; set; }
        public string City { get; set; }
        public DateTime StartDateTime { get; set; }
    }

    public class EventCRUDDto : Event
    {
        public IFormFile Image { get; set; }
        public ValidationResult ValidationResult { get; set; }
    }
}
