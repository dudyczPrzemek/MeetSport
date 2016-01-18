using GoldenEye.Shared.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetSport.Shared.DTOs
{
    public class AddressDTO : DTOBase
    {
        public string City { get; set; }

        public string Street { get; set; }

        public int XCoordynates { get; set; }

        public int YCoordynates { get; set; }
    }
}
