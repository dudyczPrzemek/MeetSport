using GoldenEye.Backend.Core.Entity;
using System;

namespace MeetSport.Backend.Entities
{
    public class EventEntity : EntityBase
    {
        public virtual SportEntity Sport { get; set; }

        public virtual AddressEntity Address { get; set; }

        public string FounderName { get; set; }

        public int SportId { get; set; }

        public int AddressId { get; set; }

        public int Year { get; set; }

        public int Month { get; set; }

        public int Day { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public int PlayersNeeded { get; set; }

        public int Cost { get; set; }

        public string EventDescription { get; set; }
    }
}
