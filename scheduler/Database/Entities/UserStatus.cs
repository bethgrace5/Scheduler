using scheduler.Database.Enums;

namespace scheduler.Database.Entities
{
    public class UserStatus
    {
        public virtual User User { get; set; }
        public int UserId { get; set; }
        public virtual Status Status { get; set; }
        public int StatusId { get; set; }
    }
}