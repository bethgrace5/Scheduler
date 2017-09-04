using System;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using FluentAssertions;
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

            try
            {
                mockDbSet.SeedEnumValues<EnumEntity, TestEnum>();
            }
            catch (InvalidOperationException e)
            {
                // cannot mock AddOrUpdate - Expect it to get that far with specific error
                e.Message.ShouldBeEquivalentTo("Unable to call public, instance method AddOrUpdate on derived IDbSet<T> type 'Castle.Proxies.IDbSet`1Proxy'. Method not found.");
            }
        }
    }
}