using scheduler.Domain.ValueObjects.Base;

namespace scheduler.Domain.ValueObjects
{
    public class Address : ValueObject<Address>
    {
        public Address(int number, string street, string city, string state, int zipcode)
        {
            Number = number;
            Street = street;
            City = city;
            State = state;
            Zipcode = zipcode;
        }

        public int Number { get; }

        public string Street { get; }

        public string City { get; }

        public string State { get; }

        public int Zipcode { get; }

        protected override bool EqualsCore(Address other)
        {
            return Number == other.Number
                   && Street == other.Street
                   && City == other.City
                   && State == other.State
                   && Zipcode == other.Zipcode;
        }

        protected override int GetHashCodeCore()
        {
            throw new System.NotImplementedException();
        }
    }
}