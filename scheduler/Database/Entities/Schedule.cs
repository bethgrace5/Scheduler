using System;

namespace scheduler.Database.Entities
{
    public class Schedule
    {
        public virtual User PublishedBy { get; set; }
        public int PublishedById { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DatePublished { get; set; }
        public virtual Location Location { get; set; }
        public int LocationId { get; set; }
    }
}