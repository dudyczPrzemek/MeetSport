using AutoMapper;
using GoldenEye.Backend.Core.Service;
using MeetSport.Backend.Entities;
using MeetSport.Backend.Repository.Interfaces;
using MeetSport.Shared.DTOs;
using MeetSport.Shared.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetSport.Backend.Services
{
    public class EventRestService : RestServiceBase<EventDTO, EventEntity>, IEventRestService
    {
        private IEventRepository Repo
        {
            get { return (IEventRepository)Repository; }
        }

        IAddressRepository _addressRepo { get; set; }

        public EventRestService(IEventRepository repository, IAddressRepository adressRepo)
            : base(repository)
        {
            _addressRepo = adressRepo;
        }

        public override Task<EventDTO> Put(EventDTO dto)
        {
            var mappedAddres = Mapper.Map<AddressDTO, AddressEntity>(dto.Address);
            var addedAddress = _addressRepo.Add(mappedAddres);

            var mappedEvent = Mapper.Map<EventDTO, EventEntity>(dto);
            mappedEvent.AddressId = addedAddress.Id;
            mappedEvent.SportId = dto.Sport.Id;
            mappedEvent.Sport = null;
            mappedEvent.Day = dto.Date.Day;
            mappedEvent.Month = dto.Date.Month;
            mappedEvent.Year = dto.Date.Year;

            var result = Repository.Add(mappedEvent);

            Repository.SaveChanges();

            return  Task.Run(() => Mapper.Map<EventDTO>(result));
        }

        public IList<EventDTO> GetNewEvents(string cityName, string userName)
        {
            var entityList = Repo.GetNewEvents(cityName, userName);

            var result = Mapper.Map<IList<EventEntity>, IList<EventDTO>>(entityList);
            foreach (var entity in entityList)
            {
                var eventTemp = result.FirstOrDefault(val => val.Id == entity.Id);

                eventTemp.Date = new DateTime(entity.Year, entity.Month, entity.Day);
                eventTemp.Sport = Mapper.Map<SportEntity, SportsDTO>(entity.Sport);

            }

            return result;
        }

        public IList<EventDTO> GetFilteredEvents(string cityName, string sportName, DateTime date, string userName)
        {
            var entityList = Repo.GetFilteredEvents(cityName, sportName, date, userName);

            var result = Mapper.Map<IList<EventEntity>, IList<EventDTO>>(entityList);
            foreach (var entity in entityList)
            {
                var eventTemp = result.FirstOrDefault(val => val.Id == entity.Id);

                eventTemp.Date = new DateTime(entity.Year, entity.Month, entity.Day);
                eventTemp.Sport = Mapper.Map<SportEntity, SportsDTO>(entity.Sport);
                eventTemp.Address = Mapper.Map<AddressEntity, AddressDTO>(entity.Address);
            }

            return result;
        }

        public IList<EventDTO> GetById(int id) {
            var entityBase = Repo.GetById(id);
            var entityList = new List<EventEntity>();

            entityList.Add(entityBase);

            var result = Mapper.Map<IList<EventEntity>, IList<EventDTO>>(entityList);
            foreach (var entity in entityList)
            {
                var eventTemp = result.FirstOrDefault(val => val.Id == entity.Id);

                eventTemp.Date = new DateTime(entity.Year, entity.Month, entity.Day);
                eventTemp.Sport = Mapper.Map<SportEntity, SportsDTO>(entity.Sport);
                eventTemp.Address = Mapper.Map<AddressEntity, AddressDTO>(entity.Address);
            }

            return result;
        }

        public IList<EventDTO> GetForUser(string userName)
        {
            var entityList = Repo.GetForUser(userName);

            var result = Mapper.Map<IList<EventEntity>, IList<EventDTO>>(entityList);
            foreach (var entity in entityList)
            {
                var eventTemp = result.FirstOrDefault(val => val.Id == entity.Id);

                eventTemp.Date = new DateTime(entity.Year, entity.Month, entity.Day);
                eventTemp.Sport = Mapper.Map<SportEntity, SportsDTO>(entity.Sport);
                eventTemp.Address = Mapper.Map<AddressEntity, AddressDTO>(entity.Address);
            }

            return result;
        }
    }
}
