using System;

namespace scheduler.Domain.Entities.Relationships
{
    public class UserLocationHistory
    {
        public DateTime DateEmployed { get; set; }
        public DateTime DateUnemployed { get; set; }

        #region navigationProperties

        public int UserId { get; set; }

        public virtual User User { get; set; }

        public int LocationId { get; set; }

        public virtual Location Location { get; set; }

        #endregion
    }
}