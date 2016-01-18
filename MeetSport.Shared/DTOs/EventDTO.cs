using GoldenEye.Shared.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetSport.Shared.DTOs
{
    public class EventDTO : DTOBase
    {
        public int Id {get;set;}

        public string FounderName { get;set;}

        public SportsDTO Sport { get; set; }

        public AddressDTO Address { get; set; }

        public DateTime Date { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public int PlayersNeeded { get; set; }

        public int Cost { get; set; }

        public string EventDescription { get; set; }
    }
}
