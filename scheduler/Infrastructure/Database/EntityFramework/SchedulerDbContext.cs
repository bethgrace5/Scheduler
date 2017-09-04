using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using scheduler.Domain.Entities;
using scheduler.Domain.EnumEntities;
using scheduler.Domain.Relationships;
using scheduler.Domain.ValueObjects;
using TimeZone = scheduler.Domain.EnumEntities.TimeZone;

namespace scheduler.Infrastructure.Database.EntityFramework
{
    public class SchedulerDbContext : DbContext, ISchedulerDbContext
    {
        public SchedulerDbContext() : base("DevelopmentSchedulerDbContext")
        {
        }

        public DbSet<Availability> Availability { get; set; }
        public DbSet<HourChangeReason> HourChangeReason { get; set; }
        public DbSet<Weekday> Weekday { get; set; }
        public DbSet<Business> Business { get; set; }
        public DbSet<LeaveOfAbsence> LeaveOfAbsence { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<Notification> Notification { get; set; }
        public DbSet<NotificationMedia> NotificationMedia { get; set; }
        public DbSet<Permission> Permission { get; set; }
        public DbSet<ReceivablesSchedule> ReceivablesSchedule { get; set; }
        public DbSet<Schedule> Schedule { get; set; }
        public DbSet<ScheduleSettings> ScheduleSettings { get; set; }
        public DbSet<Shift> Shift { get; set; }
        public DbSet<TimeZone> TimeZone { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<UserLocationHistory> UserLocationHistory { get; set; }
        public DbSet<UserPermission> UserPermission { get; set; }
        public DbSet<UserScheduledForShift> UserScheduledForShift { get; set; }
        public DbSet<TemporaryLocationHourChange> TemporaryLocationHourChange { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<UserStatus> UserStatus { get; set; }
        public DbSet<UserNotificationSettings> UserNotificationSettings { get; set; }
        public DbSet<UserPosition> UserPosition { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Language> Language { get; set; }
        public DbSet<UsStatesAndTerritories> UsStatesAndTerritorieses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Availability>()
                .HasKey(t => new {t.UserId, t.WeekdayId});

            modelBuilder.Entity<ScheduleSettings>()
                .HasKey(t => new {t.BusinessId});

            modelBuilder.Entity<ReceivablesSchedule>()
                .HasKey(t => t.Title);

            modelBuilder.Entity<UserLocationHistory>()
                .HasKey(t => t.UserId);

            modelBuilder.Entity<UserPermission>()
                .HasKey(t => t.UserId);

            modelBuilder.Entity<UserPosition>()
                .HasKey(t => t.UserId);

            modelBuilder.Entity<Schedule>()
                .HasKey(t => new {t.LocationId, t.StartDate});

            modelBuilder.Entity<UserNotificationSettings>()
                .HasKey(t => new {t.UserId, t.NotificaitonId, t.MediaId});

            modelBuilder.Entity<UserStatus>()
                .HasKey(t => new {t.UserId, t.StatusId});

            modelBuilder.Entity<LeaveOfAbsence>()
                .HasKey(t => new { t.RequestedById, t.StartDateTime });

            modelBuilder.Entity<Position>()
                .HasKey(t => new { t.LocationId, t.Name });

            modelBuilder.Entity<TemporaryLocationHourChange>()
                .HasKey(t => new { t.LocationId, t.StartDateTime});

            // remove pluralization of table names
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            base.OnModelCreating(modelBuilder);
        }
    }
}