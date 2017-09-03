using scheduler.Database.Enums;
using scheduler.Database.Enums.Extensions;

namespace scheduler.Database.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SchedulerDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Database\Migrations";
        }

        protected override void Seed(SchedulerDbContext context)
        {
            context.HourChangeReason.SeedEnumValues<HourChangeReason, HourChangeReasonEnum>();
            context.Notification.SeedEnumValues<Notification, NotificationEnum>();
            context.NotificationMedia.SeedEnumValues<NotificationMedia, NotificationMediaEnum>();
            context.Permission.SeedEnumValues<Permission, PermissionEnum>();
            context.Role.SeedEnumValues<Role, RoleEnum>();
            context.Status.SeedEnumValues<Status, StatusEnum>();
            context.TimeZone.SeedEnumValues<Enums.TimeZone, TimeZoneEnum>();
            context.Weekday.SeedEnumValues<Weekday, WeekdayEnum>();

            context.SaveChanges();
        }
    }
}
