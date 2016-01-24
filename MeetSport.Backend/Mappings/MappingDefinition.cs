using AutoMapper;
using GoldenEye.Backend.Security.Model;
using MeetSport.Backend.Entities;
using GoldenEye.Shared.Core.DTOs;
using GoldenEye.Shared.Core.Mappings;
using MeetSport.Shared.DTOs;

namespace MeetSport.Backend.Mappings
{
    public class MappingDefinition : Profile, IMappingDefinition
    {
        protected override void Configure()
        {
            Mapper.CreateMap<TaskEntity, TaskDTO>()
                .IgnoreNonExistingProperties();
            Mapper.CreateMap<TaskDTO, TaskEntity>()
                .IgnoreNonExistingProperties();
            Mapper.CreateMap<User, UserDTO>()
                .IgnoreNonExistingProperties();
            Mapper.CreateMap<UserDTO, User>()
                .IgnoreNonExistingProperties();
            Mapper.CreateMap<SportEntity, SportsDTO>()
                .IgnoreNonExistingProperties();

            Mapper.CreateMap<EventEntity, EventDTO>()
                .IgnoreNonExistingProperties();
            Mapper.CreateMap<EventDTO, EventEntity>()
                .IgnoreNonExistingProperties();

            Mapper.CreateMap<AddressDTO, AddressEntity>()
                .IgnoreNonExistingProperties();
            Mapper.CreateMap<AddressEntity, AddressDTO>()
                .IgnoreNonExistingProperties();

            Mapper.CreateMap<SportEntity, SportsDTO>()
                .IgnoreNonExistingProperties();

            Mapper.CreateMap<TransmissionDTO, TransmissionEntity>()
                .IgnoreNonExistingProperties();
            Mapper.CreateMap<TransmissionEntity, TransmissionDTO>()
                .IgnoreNonExistingProperties();
        }
    }
}