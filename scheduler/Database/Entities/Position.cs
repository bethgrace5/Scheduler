using scheduler.Database.Entities.Base;

namespace scheduler.Database.Entities
{
    public class Position : Entity
    {
        #region navigationProperties

        public int UserId { get; set; }

        public virtual User User { get; set; }

        #endregion
    }
}