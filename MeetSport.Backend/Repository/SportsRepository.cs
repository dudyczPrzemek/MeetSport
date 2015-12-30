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
    public class SportsRepository : RepositoryBase<SportEntity>, ISportsRepository
    {
        public SportsRepository(ISampleContext context) 
            : base(context, context.Sports)
        {
        }

        public IQueryable<SportEntity> GetAll() 
        {
            var result = DbSet.AsQueryable();

            return result;
        }
    }
}
