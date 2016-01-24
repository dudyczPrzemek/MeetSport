using GoldenEye.Backend.Core.Entity;
using System;

namespace MeetSport.Backend.Entities
{
    public class UsersFriendEntity : EntityBase
    {
        public string UserName { get; set; }

        public string FriendName { get; set; }

        public DateTime FriendshipStartDate { get; set; }
    }
}
