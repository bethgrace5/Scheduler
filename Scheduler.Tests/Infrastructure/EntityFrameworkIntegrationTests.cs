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
    }
}