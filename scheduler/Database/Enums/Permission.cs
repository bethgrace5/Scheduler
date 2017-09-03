using System.ComponentModel;
using scheduler.Database.Entities.Base;
using scheduler.Database.Enums.Base;

namespace scheduler.Database.Enums
{
    public enum PermissionEnum
    {
        [Description("Manage Schedule")]
        ManageSchedules = 1,

        [Description("Manage Employees")]
        ManageEmployees = 2,

        [Description("Manage Users")]
        ManageUsers = 3,

        [Description("Manage Business")]
        ManageBusiness = 4,

        [Description("Manage Self")]
        ManageSelf = 5,
    }

    public class Permission : ValueObject
    {
    }
}