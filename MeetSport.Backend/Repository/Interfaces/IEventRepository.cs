using GoldenEye.Backend.Core.Repository;
using MeetSport.Backend.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetSport.Backend.Repository.Interfaces
{
    public interface IEventRepository : IRepository<EventEntity>
    {
        IList<EventEntity> GetNewEvents(string cityName, string userName);

        IList<EventEntity> GetFilteredEvents(string cityName, string sportName, DateTime date);
    }
}
