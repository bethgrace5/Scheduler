using System.ComponentModel;
using scheduler.Database.Entities.Base;
using scheduler.Database.Enums.Base;

namespace scheduler.Database.Enums
{
    public enum RoleEnum
    {
        [Description("Administrator Role")]
        Administrator = 1,

        [Description("Business Level Role")]
        Business = 2,

        [Description("Location Level Role")]
        Location = 3,

        [Description("Employee Level Role")]
        Employee = 4
    }

    public class Role : ValueObject
    {
    }
}