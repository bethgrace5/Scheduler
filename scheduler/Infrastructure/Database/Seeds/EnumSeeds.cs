using System.ComponentModel;

namespace scheduler.Infrastructure.Database.Seeds
{
    internal enum HourChangeReasonEnum
    {
        [Description("No Reason Specified")] None,
        [Description("Holiday")] Holiday
    }

    internal enum NotificationEnum

    {
        [Description("New Schedule Has Been Published")] NewSchedulePublished
    }

    internal enum NotificationMediaEnum
    {
        [Description("Email Notification")] Email,
        [Description("Text Message Notification")] Text,
        [Description("Push Notification")] Push
    }

    internal enum PermissionEnum
    {
        [Description("Manage Schedule")] ManageSchedules,
        [Description("Manage Employees")] ManageEmployees,
        [Description("Manage Users")] ManageUsers,
        [Description("Manage Business")] ManageBusiness,
        [Description("Manage Self")] ManageSelf
    }

    internal enum RoleEnum
    {
        [Description("Administrator Role")] Administrator,
        [Description("Business Level Role")] Business,
        [Description("Location Level Role")] Location,
        [Description("Employee Level Role")] Employee
    }

    internal enum StatusEnum
    {
        [Description("Active")] Active,
        [Description("Disabled")] Disabled
    }

    internal enum TimeZoneEnum
    {
        [Description("Pacific Standard Time")] Pacific
    }

    internal enum WeekdayEnum
    {
        [Description("Sunday")] Sunday,
        [Description("Monday")] Monday,
        [Description("Tuesday")] Tuesday,
        [Description("Wednesday")] Wednesday,
        [Description("Thursday")] Thursday,
        [Description("Friday")] Friday,
        [Description("Saturday")] Saturday
    }
}