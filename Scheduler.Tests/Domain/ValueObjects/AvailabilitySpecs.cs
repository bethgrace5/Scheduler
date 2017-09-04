using System;
using FluentAssertions;
using scheduler.Domain.ValueObjects;
using Xunit;

namespace Scheduler.Tests.Domain.ValueObjects
{
    public class AvailabilitySpecs
    {
        [Fact]
        public void Availabilities_end_time_should_be_after_start_time()
        {
            var startTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 6, 0, 0);
            var endTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 7, 0, 0);

            var availability = new Availability(1, 1, startTime, endTime);
        }

        [Fact]
        public void Availabilities_should_be_equivalent()
        {
            var startTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 6, 0, 0);
            var endTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 7, 0, 0);


            var availability1 = new Availability(1, 1, startTime, endTime);
            var availability2 = new Availability(1, 1, startTime, endTime);

            availability1.ShouldBeEquivalentTo(availability2);
        }

        [Fact]
        public void Availability_hash_codes_should_be_equivalent()
        {
            var startTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 6, 0, 0);
            var endTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 7, 0, 0);


            var availability1 = new Availability(1, 1, startTime, endTime);
            var availability2 = new Availability(1, 1, startTime, endTime);

            availability1.GetHashCode().ShouldBeEquivalentTo(availability2.GetHashCode());
        }

        [Fact]
        public void Availabilities_start_time_should_not_equal_end_time()
        {
            try
            {
                var availability = new Availability(1, 1,
                    new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 6, 0, 0),
                    new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 6, 0, 0));
            }
            catch (ArgumentException e)
            {
                e.Should().NotBeNull();
            }
        }

        [Fact]
        public void Availabilities_start_time_hour_should_not_be_after_end_time()
        {
            try
            {
                var availability = new Availability(1, 1,
                    new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 6, 0, 0),
                    new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 5, 0, 0));
            }
            catch (ArgumentException e)
            {
                e.Should().NotBeNull();
            }
        }

        [Fact]
        public void Availabilities_start_time_minute_should_not_be_after_end_time()
        {
            try
            {
                var availability = new Availability(1, 1,
                    new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 6, 1, 0),
                    new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 6, 0, 0));
            }
            catch (ArgumentException e)
            {
                e.Should().NotBeNull();
            }
        }

        [Fact]
        public void Availabilities_with_different_start_times_should_not_be_equivalent()
        {
            var availability1 = new Availability(1, 1, DateTime.Today, DateTime.Today.AddMinutes(1));
            var availability2 = new Availability(1, 1, DateTime.Today.AddHours(1), DateTime.Today.AddHours(2));

            availability1.Should().NotBe(availability2);
        }

        [Fact]
        public void Availabilities_with_different_users_should_not_be_equivalent()
        {
            var availability1 = new Availability(1, 1, DateTime.Today, DateTime.Today.AddHours(1));
            var availability2 = new Availability(2, 1, DateTime.Today, DateTime.Today.AddHours(1));

            availability1.Should().NotBe(availability2);
        }

        [Fact]
        public void Availabilities_with_different_weekdays_should_not_be_equivalent()
        {
            var availability1 = new Availability(1, 1, DateTime.Today, DateTime.Today.AddHours(1));
            var availability2 = new Availability(1, 2, DateTime.Today, DateTime.Today.AddHours(1));

            availability1.Should().NotBe(availability2);
        }
    }
}