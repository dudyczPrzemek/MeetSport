using AutoMapper;
using GoldenEye.Backend.Core.Service;
using MeetSport.Backend.Entities;
using MeetSport.Backend.Repository.Interfaces;
using MeetSport.Shared.DTOs;
using MeetSport.Shared.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetSport.Backend.Services
{
    public class SportsRestService : RestServiceBase<SportsDTO, SportEntity>, ISportsRestService
    {
        public SportsRestService(ISportsRepository repository) 
            :base(repository)
        {
        }

        public override IQueryable<SportsDTO> Get() 
        {
            var result = Repository.GetAll().ToList();

            return Mapper.Map<List<SportEntity>, List<SportsDTO>>(result).AsQueryable();
        }
    }
}
