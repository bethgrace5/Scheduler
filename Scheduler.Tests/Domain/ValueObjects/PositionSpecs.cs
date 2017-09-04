﻿using FluentAssertions;
using scheduler.Domain.ValueObjects;
using Xunit;

namespace Scheduler.Tests.Domain.ValueObjects
{
    public class PositionSpecs
    {
        [Fact]
        public void Posiitons_with_the_same_location_and_name_should_be_equivalent()
        {
            var position1 = new Position(1, "Name");
            var position2 = new Position(1, "Name");

            position1.Should().Be(position2);
        }

        [Fact]
        public void Posiitons_with_different_locations_should_not_be_equivalent()
        {
            var position1 = new Position(1, "Name");
            var position2 = new Position(2, "Name");

            position1.Should().NotBe(position2);
        }

        [Fact]
        public void Posiitons_with_different_names_should_not_be_equivalent()
        {
            var position1 = new Position(1, "Name");
            var position2 = new Position(1, "Name2");

            position1.Should().NotBe(position2);
        }

    }
}