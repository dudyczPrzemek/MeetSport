using System.Data.Entity;
using GoldenEye.Backend.Core.Context;
using MeetSport.Backend.Entities;

namespace MeetSport.Backend.Context
{
    public interface ISampleContext: IDataContext
    {
        IDbSet<TaskEntity> Tasks { get; }
    }
}