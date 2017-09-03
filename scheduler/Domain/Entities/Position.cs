using scheduler.Domain.Entities.Base;

namespace scheduler.Domain.Entities
{
    public class Position : Entity
    {
        #region navigationProperties

        public int UserId { get; set; }

        public virtual User User { get; set; }

        #endregion
    }
}