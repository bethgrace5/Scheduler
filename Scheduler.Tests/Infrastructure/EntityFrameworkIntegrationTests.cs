using System.Data;
using System.Net.Mime;
using FluentAssertions;
using scheduler.Infrastructure.EntityFramework;
using Xunit;

namespace Scheduler.Tests.Infrastructure
{
    public class EntityFrameworkIntegrationTests
    {
        [Fact]
        public void Should_have_database_connection_string()
        {
            using (var context = new SchedulerDbContext())
            {
                context.Database.Should().NotBeNull();

                context.Database.Connection.Should().NotBeNull();

                context.Database.Connection.DataSource.Should().NotBeNullOrEmpty();
            }
        }

        [Fact]
        public void Should_open_and_close_connection_to_existing_databasee()
        {
            using (var context = new SchedulerDbContext())
            {
                if (context.Database.Exists())
                {
                    var conn = context.Database.Connection;

                    conn.State.ToString().ShouldBeEquivalentTo(ConnectionState.Closed.ToString());

                    conn.Open();

                    conn.State.ToString().ShouldBeEquivalentTo(ConnectionState.Open.ToString());

                    conn.Close();

                    conn.State.ToString().ShouldBeEquivalentTo(ConnectionState.Closed.ToString());
                }
            }
        }
    }
}