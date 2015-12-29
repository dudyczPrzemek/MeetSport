using FluentValidation;
using GoldenEye.Backend.Core.Service;
using MeetSport.Backend.Entities;
using MeetSport.Backend.Repository;
using MeetSport.Shared.DTOs;
using MeetSport.Shared.Services;
using MeetSport.Shared.Validators;

namespace MeetSport.Backend.Services
{
    public class TaskRestService: RestServiceBase<TaskDTO, TaskEntity>, ITaskRestService
    {
        public TaskRestService(ITaskRepository repository)
            : base(repository)
        {
        }

        protected override AbstractValidator<TaskDTO> GetValidator()
        {
            return new TaskValidator();
        }
    }
}
