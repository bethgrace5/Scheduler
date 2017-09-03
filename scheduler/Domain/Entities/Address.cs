﻿using scheduler.Domain.Entities.Base;

namespace scheduler.Domain.Entities
{
    public class Address : Entity
    {
        public int Zipcode { get; set; }

        public int Number { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Street { get; set; }
    }
}