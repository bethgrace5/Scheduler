using System.Data.Entity.Migrations;
using scheduler.Domain.Entities.EnumEntities;
using scheduler.Domain.ValueObjects.Extensions;
using scheduler.Infrastructure.Database.Seeds;

namespace scheduler.Infrastructure.EntityFramework.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<SchedulerDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Database\EntityFramework\Migrations";
        }

        protected override void Seed(SchedulerDbContext context)
        {
            context.Role.SeedEnumValues<Role, RoleEnum>();

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}