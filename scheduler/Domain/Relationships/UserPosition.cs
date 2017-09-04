using scheduler.Domain.Entities;
using scheduler.Domain.Entities.Base;
using scheduler.Domain.ValueObjects;

namespace scheduler.Domain.Relationships
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