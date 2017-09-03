using System.Data;
using FluentAssertions;
using scheduler.Database.Entities.EnumEntities;
using scheduler.Database.Seeds;
using scheduler.Database.ValueObjects;
using scheduler.Database.ValueObjects.Extensions;
using Xunit;

namespace scheduler.Database.Tests
{
    public class EntityFramework
    {
        [Fact]
        public void Should_open_and_close_connection_to_database()
        {
            using (var context = new SchedulerDbContext())
            {
                context.Database.Exists().Should().BeTrue();

                var conn = context.Database.Connection;

                conn.State.ToString().ShouldBeEquivalentTo(ConnectionState.Closed.ToString());

                conn.Open();

                conn.State.ToString().ShouldBeEquivalentTo(ConnectionState.Open.ToString());

                conn.Close();

                conn.State.ToString().ShouldBeEquivalentTo(ConnectionState.Closed.ToString());

            }
        }

        [Fact]
        public void Seed_enum_values_should_work()
        {
            using (var context = new SchedulerDbContext())
            {
                context.Role.SeedEnumValues<Role, RoleEnum>();
            }
        }
    }
}