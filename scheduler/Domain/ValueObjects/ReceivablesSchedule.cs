using scheduler.Domain.Entities;
using scheduler.Domain.ValueObjects.Base;

namespace scheduler.Domain.ValueObjects
{
    public class ReceivablesSchedule : ValueObject
    {
        public string Title { get; set; }
        public bool Monday { get; set; }
        public bool Tuesday { get; set; }
        public bool Wednesday { get; set; }
        public bool Thursday { get; set; }
        public bool Friday { get; set; }
        public bool Saturday { get; set; }
        public bool Sunday { get; set; }

        #region navigationProperties

        public int LocationId { get; set; }

        public virtual Location Location { get; set; }

        #endregion
    }
}