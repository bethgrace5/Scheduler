using System.Data.Entity.Migrations;
using scheduler.Domain.Entities.Enums;
using scheduler.Domain.Entities.Enums.Extensions;
using scheduler.Infrastructure.Database.Seeds;

namespace scheduler.Infrastructure.Database.EntityFramework.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<SchedulerDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Infrastructure\Database\EntityFramework\Migrations";
        }

        protected override void Seed(SchedulerDbContext context)
        {
            // EnumSeeds add and update
            context.HourChangeReason.SeedEnumValues<HourChangeReason, HourChangeReasonEnum>();
            context.Notification.SeedEnumValues<Notification, NotificationEnum>();
            context.NotificationMedia.SeedEnumValues<NotificationMedia, NotificationMediaEnum>();
            context.Role.SeedEnumValues<Role, RoleEnum>();
            context.Status.SeedEnumValues<Status, StatusEnum>();
            context.TimeZone.SeedEnumValues<TimeZone, TimeZoneEnum>();
            context.Weekday.SeedEnumValues<Weekday, WeekdayEnum>();
            context.Country.SeedEnumValues<Country, CountryEnum>();
            context.Language.SeedEnumValues<Language, LanguageEnum>();
            context.UsStatesAndTerritorieses.SeedEnumValues<UsStatesAndTerritories, UsStatesAndTerritoriesEnum>();
        }
    }
}