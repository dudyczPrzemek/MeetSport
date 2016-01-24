using System.Data.Entity;
using GoldenEye.Backend.Core.Context;
using MeetSport.Backend.Entities;
using Microsoft.AspNet.Identity.EntityFramework;

namespace MeetSport.Backend.Context
{
    public class SampleContext: DataContext<SampleContext>, ISampleContext
    {
        public SampleContext()
            : base("name=DBConnectionString")
        {
        }

        public SampleContext(IConnectionProvider connectionProvider)
            : base(connectionProvider)
        {
        }

        public IDbSet<TaskEntity> Tasks { get; set; }

        public IDbSet<SportEntity> Sports { get; set; }

        public IDbSet<RatingEntity> Ratings { get; set; }

        public IDbSet<AddressEntity> Address { get; set; }

        public IDbSet<EventEntity> Event { get; set; }

        public IDbSet<UsersFriendEntity> UserFriends { get; set; }

        public IDbSet<EventUsersEntity> EventUsers { get; set; }

        public IDbSet<TransmissionEntity> Transmissions { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TaskEntity>()
                .ToTable("Tasks")
                .HasKey(o => o.Id);

            modelBuilder.Entity<SportEntity>()
                .ToTable("Sports")
                .HasKey(o => o.Id);

            modelBuilder.Entity<RatingEntity>()
                .ToTable("Ratings")
                .HasKey(o => o.Id);

            modelBuilder.Entity<AddressEntity>()
                .ToTable("Address")
                .HasKey(o => o.Id);

            modelBuilder.Entity<EventEntity>()
                .ToTable("Events")
                .HasKey(o => o.Id);

            modelBuilder.Entity<UsersFriendEntity>()
                .ToTable("UserFriends")
                .HasKey(o => o.Id);

            modelBuilder.Entity<EventUsersEntity>()
                .ToTable("EventUsers")
                .HasKey(o => o.Id);

            modelBuilder.Entity<TransmissionEntity>()
                .ToTable("Transmissions")
                .HasKey(o => o.Id);

            modelBuilder.Entity<IdentityUserLogin>().HasKey<string>(l => l.UserId);
            modelBuilder.Entity<IdentityRole>().HasKey<string>(r => r.Id);
            modelBuilder.Entity<IdentityUserRole>().HasKey(r => new { r.RoleId, r.UserId });
        }
    }
}