using GoldenEye.Shared.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetSport.Shared.DTOs
{
    public class TransmissionDTO : DTOBase
    {
        public int Id { get; set; }

        public string Url { get; set; }

        public string OwnerName { get; set; }

        public DateTime EndDate { get; set; }

        public string Title { get; set; }
    }
}
