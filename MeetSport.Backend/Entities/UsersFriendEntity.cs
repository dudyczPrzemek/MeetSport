using GoldenEye.Backend.Core.Entity;
using GoldenEye.Backend.Security.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetSport.Backend.Entities
{
    public class UsersFriendEntity : EntityBase
    {
        public string UserName { get; set; }

        public string FriendName { get; set; }

        public DateTime FriendshipStartDate { get; set; }
    }
}
