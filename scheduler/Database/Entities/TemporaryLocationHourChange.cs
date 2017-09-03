using System;
using scheduler.Database.Entities.Base;

namespace scheduler.Database.Entities
{
    public class TemporaryLocationHourChange : EntityBase<int>
    {
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public string ReasonId { get; set; }
        public bool IsOpen { get; set; }

        #region navigationProperties

        public int LocationId { get; set; }

        public virtual Location Location { get; set; }

        #endregion
    }
}