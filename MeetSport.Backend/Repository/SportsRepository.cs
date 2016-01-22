using GoldenEye.Backend.Core.Repository;
using MeetSport.Backend.Context;
using MeetSport.Backend.Entities;
using MeetSport.Backend.Repository.Interfaces;

namespace MeetSport.Backend.Repository
{
    public class SportsRepository : RepositoryBase<SportEntity>, ISportsRepository
    {
        public SportsRepository(ISampleContext context) 
            : base(context, context.Sports)
        {
        }
    }
}
