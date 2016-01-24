using GoldenEye.Shared.Core.Services;
using MeetSport.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetSport.Shared.Services
{
    public interface IEventRestService : IRestService<EventDTO>
    {
        IList<EventDTO> GetById(int id);

        IList<EventDTO> GetForUser(string userName);

        IList<EventDTO> GetNewEvents(string cityName, string userName);

        IList<EventDTO> GetFilteredEvents(string cityName, string sportName, DateTime date, string userName);
    }
}
