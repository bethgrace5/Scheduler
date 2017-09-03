using scheduler.Domain.Entities.Base;

namespace scheduler.Domain.Entities.Relationships
{
    public class UserPosition : Entity
    {
        public bool IsPrimary { get; set; }
        public bool IsTraining { get; set; }

        #region navigationProperties

        public int UserId { get; set; }

        public virtual User User { get; set; }

        public int PositionId { get; set; }

        public virtual Position Position { get; set; }

        #endregion
    }
}