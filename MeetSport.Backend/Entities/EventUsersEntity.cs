using GoldenEye.Backend.Core.Entity;

namespace MeetSport.Backend.Entities
{
    public class EventUsersEntity: EntityBase
    {
        public EventEntity Event { get; set; }

        public string UserName { get; set; }

        public int EventId { get; set; }
    }
}
