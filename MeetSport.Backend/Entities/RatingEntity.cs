using GoldenEye.Backend.Core.Entity;

namespace MeetSport.Backend.Entities
{
    public class RatingEntity : EntityBase
    {
        public string OwnerName { get; set; }

        public string AuthorName { get; set; }

        public int Rating { get; set; }

        public string Comment { get; set; }
    }
}
