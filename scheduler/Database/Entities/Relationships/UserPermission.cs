﻿using scheduler.Database.Enums;

namespace scheduler.Database.Entities.Relationships
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