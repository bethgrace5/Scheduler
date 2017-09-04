using System.Threading.Tasks;
using FluentAssertions;
using scheduler.Domain.ValueObjects;
using Xunit;

namespace Scheduler.Tests.Domain.ValueObjects
{
    public class AddressSpecs
    {
        [Fact]
        public void Addresses_should_be_equivalent()
        {
            var Address1 = new Address(1234, "sesame street", "San Diego", "CA", 12345);
            var Address2 = new Address(1234, "sesame street", "San Diego", "CA", 12345);

            Address1.Should().Be(Address2);
        }

        [Fact]
        public void Addresses_should_match_hash_code()
        {
            var address1 = new Address(1234, "sesame street", "San Diego", "CA", 12345);
            var address2 = new Address(1234, "sesame street", "San Diego", "CA", 12345);

            address1.GetHashCode().ShouldBeEquivalentTo(address2.GetHashCode());
        }

        [Fact]
        public void Addresses_with_different_number_should_not_match_hash_code()
        {
            var address1 = new Address(1234, "sesame street", "San Diego", "CA", 12345);
            var address2 = new Address(0000, "sesame street", "San Diego", "CA", 12345);

            address1.GetHashCode().Should().NotBe(address2.GetHashCode());
        }

        [Fact]
        public void Addresses_with_different_street_should_not_match_hash_code()
        {
            var address1 = new Address(1234, "sesame street", "San Diego", "CA", 12345);
            var address2 = new Address(1234, "0000000000000", "San Diego", "CA", 12345);

            address1.GetHashCode().Should().NotBe(address2.GetHashCode());
        }

        [Fact]
        public void Addresses_with_different_city_should_not_match_hash_code()
        {
            var address1 = new Address(1234, "sesame street", "San Diego", "CA", 12345);
            var address2 = new Address(1234, "sesame street", "000000000", "CA", 12345);

            address1.GetHashCode().Should().NotBe(address2.GetHashCode());
        }

        [Fact]
        public void Addresses_with_different_zip_should_not_match_hash_code()
        {
            var address1 = new Address(1234, "sesame street", "San Diego", "CA", 12345);
            var address2 = new Address(1234, "sesame street", "San Diego", "CA", 00000);

            address1.GetHashCode().Should().NotBe(address2.GetHashCode());
        }

        [Fact]
        public void Addresses_should_trim_strings()
        {
            var address = new Address(1234, " sesame street ", " San Diego ", " CA" , 12345);

            address.Street.ShouldBeEquivalentTo("sesame street");
            address.City.ShouldBeEquivalentTo("San Diego");
            address.State.ShouldBeEquivalentTo("CA");
        }
    }
}