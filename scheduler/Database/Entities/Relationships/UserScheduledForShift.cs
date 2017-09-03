using System;

namespace scheduler.Database.Entities.Relationships
{
    public class UserScheduledForShift
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        #region navigationProperties

        public int UserId { get; set; }

        public virtual User User { get; set; }

        public int ShiftId { get; set; }

        public virtual Shift Shift { get; set; }

        #endregion
    }
}