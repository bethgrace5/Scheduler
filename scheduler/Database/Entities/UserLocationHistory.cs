using System;

namespace scheduler.Database.Entities
{
    public class UserLocationHistory
    {
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public DateTime DateEmployed { get; set; }
        public DateTime DateUnemployed { get; set; }
        public int LocationId { get; set; }
        public virtual Location Location { get; set; }
    }
}