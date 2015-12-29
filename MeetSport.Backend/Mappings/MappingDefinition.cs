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
        }
    }
}