using scheduler.Database.Entities.Base;

namespace scheduler.Database.Entities
{
    public class Address : EntityBase<int>
    {
        public int Zipcode { get; set; }

        public int Number { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Street { get; set; }
    }
}