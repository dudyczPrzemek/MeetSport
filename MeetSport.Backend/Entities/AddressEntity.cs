using GoldenEye.Backend.Core.Entity;

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
