using System.ComponentModel;
using System.Data.Entity;
using NSubstitute;
using scheduler.Domain.Entities.EnumEntities.Base;
using scheduler.Domain.ValueObjects.Extensions;
using Xunit;

namespace Scheduler.Tests.Infrastructure
{
    public enum TestEnum
    {
        [Description("Test1 Description")] Test1,
        [Description("Test2 Description")] Test2
    }

    public class EntityFrameworkUnitTests
    {
        [Fact]
        public void Seed_enum_values_should_work()
        {
            var mockDbSet = Substitute.For<IDbSet<EnumEntity>>();

            mockDbSet.SeedEnumValues<EnumEntity, TestEnum>();
        }
    }
}