using scheduler.Database.Entities.Base;

namespace scheduler.Database.Entities
{
    public class Position : ValueObject
    {
        public int UserId { get; set; }
    }
}