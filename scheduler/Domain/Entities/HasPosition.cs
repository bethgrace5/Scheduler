using scheduler.Domain.Entities.Base;

namespace scheduler.Domain.Entities
{
    public class HasPosition : Entity
    {
        public bool IsPrimary { get; set; }
        public bool IsTraining { get; set; }

        #region navigationProperties

        public virtual User User { get; set; }

        public virtual Position Position { get; set; }

        #endregion
    }
}