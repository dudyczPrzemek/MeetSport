using System.Data.Entity;
using GoldenEye.Backend.Core.Context;
using MeetSport.Backend.Entities;

namespace MeetSport.Backend.Context
{
    public interface ISampleContext: IDataContext
    {
        IDbSet<TaskEntity> Tasks { get; }

        IDbSet<SportEntity> Sports { get; }

        IDbSet<RatingEntity> Ratings { get; }

        IDbSet<AddressEntity> Address { get; }

        IDbSet<EventEntity> Event { get; }

        IDbSet<UsersFriendEntity> UserFriends { get; }

        IDbSet<EventUsersEntity> EventUsers { get; }
    }
}