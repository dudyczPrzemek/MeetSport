using GoldenEye.Backend.Core.Entity;
using GoldenEye.Backend.Security.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetSport.Backend.Entities
{
    public class EventEntity : EntityBase
    {
        public User FounderId { get; set; }

        public SportEntity SportId { get; set; }

        public AddressEntity AddressId { get; set; }

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
