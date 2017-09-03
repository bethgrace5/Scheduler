using System;

namespace scheduler.Database.Entities
{
    public class TemporaryLocationHourChange
    {
        public int Id { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public string ReasonId { get; set; }
        public int LocationId { get; set; }
        public virtual Location Location { get; set; }
        public bool IsOpen { get; set; }
    }
}