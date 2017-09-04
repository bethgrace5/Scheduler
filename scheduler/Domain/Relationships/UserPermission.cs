using scheduler.Domain.Entities;
using scheduler.Domain.EnumEntities;

namespace scheduler.Domain.Relationships
{
    public class UserPermission
    {
        #region navigationProperties

        public int UserId { get; set; }

        public virtual User User { get; set; }

        public int PermissionId { get; set; }

        public virtual Permission Permission { get; set; }

        #endregion
    }
}