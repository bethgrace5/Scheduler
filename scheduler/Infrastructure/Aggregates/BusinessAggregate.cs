using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using scheduler.Domain.Entities;

namespace scheduler.Infrastructure.Aggregates
{
    public class BusinessAggregate
    {
        public BusinessAggregate()
        {
            Locations = new List<Location>();
        }

        public Business Business { get; set; }

        public List<Location> Locations { get; set; }

        public ScheduleSettings ScheduleSettings { get; set; }
    }
}
