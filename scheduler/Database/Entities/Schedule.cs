using System;
using scheduler.Database.Entities.Base;

namespace scheduler.Database.Entities
{
    public class Schedule : EntityBase<int>
    {
        public DateTime StartDate { get; set; }
        public DateTime DatePublished { get; set; }

        #region navigationProperties

        public int LocationId { get; set; }

        public virtual Location Location { get; set; }

        public virtual User PublishedBy { get; set; }

        public int PublishedById { get; set; }

        #endregion
    }
}