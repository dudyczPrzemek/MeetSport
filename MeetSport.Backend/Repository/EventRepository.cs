using GoldenEye.Backend.Core.Repository;
using MeetSport.Backend.Context;
using MeetSport.Backend.Entities;
using MeetSport.Backend.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetSport.Backend.Repository
{
    public class EventRepository : RepositoryBase<EventEntity>, IEventRepository
    {
        public EventRepository(ISampleContext context)
            : base(context, context.Event)
        {
        }

        public override EventEntity Add(EventEntity entity)
        {
            var result = DbSet.Add(entity);
            Context.SaveChanges();
            return result;
        }

        public IList<EventEntity> GetNewEvents(string cityName, string userName)
        {
            var currentDate = DateTime.Now;

            return DbSet.Where(val => val.Year == currentDate.Year && val.Month == currentDate.Month
                && val.Day <= currentDate.Day + 2 &&val.Day >= currentDate.Day-2 && val.Address.City == cityName && val.FounderName != userName).ToList();
        }

        public IList<EventEntity> GetFilteredEvents(string cityName, string sportName, DateTime date, string userName)
        {
            return DbSet.Where(val => val.Address.City == cityName && val.Sport.Name == sportName && val.Year == date.Year
                && val.Month == date.Month && val.Day == date.Day && val.FounderName != userName).ToList();
        }

        public IList<EventEntity> GetForUser(string userName)
        {
            return DbSet.Where(val => val.FounderName == userName).ToList();
        }
    }
}
