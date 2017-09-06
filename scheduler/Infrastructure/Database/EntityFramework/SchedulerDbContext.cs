using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration.Conventions;
using scheduler.Domain.Dictionaries;
using scheduler.Domain.Entities;
using scheduler.Domain.ValueObjects;
using TimeZone = scheduler.Domain.Dictionaries.TimeZone;

namespace scheduler.Infrastructure.Database.EntityFramework
{
    public class SchedulerDbContext : DbContext, ISchedulerDbContext
    {
        public SchedulerDbContext() : base("DevelopmentSchedulerDbContext")
        {
        }

        public DbSet<Address> Address { get; set; }
        public DbSet<Availability> Availability { get; set; }
        public DbSet<HourChangeReason> HourChangeReason { get; set; }
        public DbSet<Weekday> Weekday { get; set; }
        public DbSet<Business> Business { get; set; }
        public DbSet<Absence> LeaveOfAbsence { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<Notification> Notification { get; set; }
        public DbSet<NotificationMedia> NotificationMedia { get; set; }
        public DbSet<Permission> Permission { get; set; }
        public DbSet<Receivable> ReceivablesSchedule { get; set; }
        public DbSet<Schedule> Schedule { get; set; }
        public DbSet<ScheduleSettings> ScheduleSettings { get; set; }
        public DbSet<Shift> Shift { get; set; }
        public DbSet<TimeZone> TimeZone { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<LocationHistory> UserLocationHistory { get; set; }
        public DbSet<UserScheduledForShift> UserScheduledForShift { get; set; }
        public DbSet<TemporaryLocationHourChange> TemporaryLocationHourChange { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<NotificationSettings> UserNotificationSettings { get; set; }
        public DbSet<HasPosition> UserPosition { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Language> Language { get; set; }
        public DbSet<UsStatesAndTerritories> UsStatesAndTerritorieses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // remove pluralization of table names
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            base.OnModelCreating(modelBuilder);
        }
    }
}