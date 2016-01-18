using GoldenEye.Backend.Core.Entity;
using GoldenEye.Backend.Security.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
