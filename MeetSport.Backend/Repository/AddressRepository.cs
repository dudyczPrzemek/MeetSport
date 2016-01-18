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
    public class AddressRepository : RepositoryBase<AddressEntity>, IAddressRepository
    {
        public AddressRepository(ISampleContext context) 
            : base(context, context.Address)
        {
        }
    }
}
