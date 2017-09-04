using scheduler.Domain.ValueObjects.Base;

namespace scheduler.Domain.ValueObjects
{
    public class Address : ValueObject
    {
        public int Zipcode { get; set; }

        public int Number { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Street { get; set; }
    }
}