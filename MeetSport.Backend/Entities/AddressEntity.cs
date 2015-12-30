using GoldenEye.Backend.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetSport.Backend.Entities
{
    public class AddressEntity : EntityBase
    {
        public string City { get; set; }

        public string Street { get; set; }

        public int XCoordynates { get; set; }

        public int YCoordynates { get; set; }
    }
}
