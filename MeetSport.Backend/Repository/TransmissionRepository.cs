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
    public class TransmissionRepository : RepositoryBase<TransmissionEntity>, ITransmissionRepository
    {
        public TransmissionRepository(ISampleContext context)
            : base(context, context.Transmissions)
        { }

        public override TransmissionEntity Add(TransmissionEntity entity)
        {
            var result = DbSet.Add(entity);
            Context.SaveChanges();
            return result;
        }
    }
}
