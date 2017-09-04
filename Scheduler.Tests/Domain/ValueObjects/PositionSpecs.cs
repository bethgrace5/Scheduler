using FluentAssertions;
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

        [Fact]
        public void Positions_should_match_hash_code()
        {
            var position1 = new Position(1, "Name");
            var position2 = new Position(1, "Name");

            position1.GetHashCode().Should().Be(position2.GetHashCode());
        }

        [Fact]
        public void Positions_with_different_name_should_not_match_hash_code()
        {
            var position1 = new Position(1, "Name");
            var position2 = new Position(1, "Name2");

            position1.GetHashCode().Should().NotBe(position2.GetHashCode());
        }


        [Fact]
        public void Positions_with_different_location_should_not_match_hash_code()
        {
            var position1 = new Position(1, "Name");
            var position2 = new Position(2, "Name");

            position1.GetHashCode().Should().NotBe(position2.GetHashCode());
        }

        [Fact]
        public void Positions_with_different_area_should_not_match_hash_code()
        {
            var position1 = new Position(1, "Name ", "area");
            var position2 = new Position(1, "Name");

            position1.GetHashCode().Should().NotBe(position2.GetHashCode());
        }

        [Fact]
        public void Positions_should_trim_strings()
        {
            var position1 = new Position(1, " Name ", " area ");

            position1.Name.ShouldBeEquivalentTo("Name");
            position1.Area.ShouldBeEquivalentTo("area");
        }

    }
}