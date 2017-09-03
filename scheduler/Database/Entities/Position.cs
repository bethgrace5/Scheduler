using scheduler.Database.Entities.Base;

namespace scheduler.Database.Entities
{
    public class Position : EntityBase<int>
    {
        #region navigationProperties

        public int UserId { get; set; }

        public virtual User User { get; set; }

        #endregion
    }
}