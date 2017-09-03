using scheduler.Database.Entities.Base;

namespace scheduler.Database.Entities
{
    public class ReceivablesSchedule : Entity
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