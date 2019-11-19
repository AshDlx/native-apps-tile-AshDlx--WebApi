using System;
using System.Collections.Generic;
using System.Text;

namespace PartyAtHomes_Lib
{
    public class Event : EntityBase
    {
        public string EventName { get; set; }
        public string MainImage { get; set; }
        public string City { get; set; }
        public double LocationLat { get; set; }
        public double LocationLng { get; set; }
        public User Creator { get; set; }
        public Guid CreatorId { get; set; }
    }
}
