using GoldenEye.Backend.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetSport.Backend.Entities
{
    public class TransmissionEntity : EntityBase
    {
        public string Url { get; set; }

        public string OwnerName { get; set; }

        public DateTime EndDate { get; set; }

        public string Title { get; set; }
    }
}
