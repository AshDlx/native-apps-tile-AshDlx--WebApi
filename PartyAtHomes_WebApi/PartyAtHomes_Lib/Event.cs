using System;

namespace PartyAtHomes_Lib
{
    public class Event : EntityBase
    {
        public string EventName { get; set; }
        public string MainImage { get; set; }
        public string AdressCity { get; set; }
        public string AdressCountry { get; set; }
        public string AdressStreet { get; set; }
        public string AdressNumber { get; set; }
        public string DescriptionEvent { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public double LocationLat { get; set; }
        public double LocationLng { get; set; }
        public User Creator { get; set; }
        public Guid CreatorId { get; set; }
    }
}
