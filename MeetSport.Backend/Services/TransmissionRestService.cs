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
    public class TransmissionRestService : RestServiceBase<TransmissionDTO, TransmissionEntity>, ITransmissionRestService
    {
        public TransmissionRestService(ITransmissionRepository repository)
            : base(repository)
        { }

        public override Task<TransmissionDTO> Put(TransmissionDTO dto)
        {
            var entity = Mapper.Map<TransmissionDTO, TransmissionEntity>(dto);

            Repository.Add(entity);

            return null;
        }

        public override IQueryable<TransmissionDTO> Get()
        {
            var entityList = Repository.GetAll();

            var result = new List<TransmissionDTO>();
            result = Mapper.Map<List<TransmissionEntity>, List<TransmissionDTO>>(entityList.ToList());
            
            return result.AsQueryable();
        }
    }
}
