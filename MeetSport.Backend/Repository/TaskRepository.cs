using GoldenEye.Backend.Core.Repository;
using MeetSport.Backend.Context;
using MeetSport.Backend.Entities;

namespace MeetSport.Backend.Repository
{
    public class TaskRepository: RepositoryBase<TaskEntity>, ITaskRepository
    {
        public TaskRepository(ISampleContext context): base(context, context.Tasks)
        {
        }
    }
}