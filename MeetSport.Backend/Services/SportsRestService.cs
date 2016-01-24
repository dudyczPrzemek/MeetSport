using GoldenEye.Backend.Core.Service;
using MeetSport.Backend.Entities;
using MeetSport.Backend.Repository.Interfaces;
using MeetSport.Shared.DTOs;
using MeetSport.Shared.Services;

namespace MeetSport.Backend.Services
{
    public class SportsRestService : RestServiceBase<SportsDTO, SportEntity>, ISportsRestService
    {
        public SportsRestService(ISportsRepository repository) 
            :base(repository)
        {
        }
    }
}
