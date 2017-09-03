namespace scheduler.Database.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Availability", "DateDeleted", c => c.DateTime());
            AlterColumn("dbo.User", "DateDeleted", c => c.DateTime());
            AlterColumn("dbo.Address", "DateDeleted", c => c.DateTime());
            AlterColumn("dbo.Role", "DateDeleted", c => c.DateTime());
            AlterColumn("dbo.Status", "DateDeleted", c => c.DateTime());
            AlterColumn("dbo.Weekday", "DateDeleted", c => c.DateTime());
            AlterColumn("dbo.Business", "DateDeleted", c => c.DateTime());
            AlterColumn("dbo.TimeZone", "DateDeleted", c => c.DateTime());
            AlterColumn("dbo.HourChangeReason", "DateDeleted", c => c.DateTime());
            AlterColumn("dbo.LeaveOfAbsence", "DateDeleted", c => c.DateTime());
            AlterColumn("dbo.Location", "DateDeleted", c => c.DateTime());
            AlterColumn("dbo.Notification", "DateDeleted", c => c.DateTime());
            AlterColumn("dbo.NotificationMedia", "DateDeleted", c => c.DateTime());
            AlterColumn("dbo.Permission", "DateDeleted", c => c.DateTime());
            AlterColumn("dbo.ReceivablesSchedule", "DateDeleted", c => c.DateTime());
            AlterColumn("dbo.Schedule", "DateDeleted", c => c.DateTime());
            AlterColumn("dbo.ScheduleSettings", "DateDeleted", c => c.DateTime());
            AlterColumn("dbo.Shift", "DateDeleted", c => c.DateTime());
            AlterColumn("dbo.Position", "DateDeleted", c => c.DateTime());
            AlterColumn("dbo.TemporaryLocationHourChange", "DateDeleted", c => c.DateTime());
            AlterColumn("dbo.UserPosition", "DateDeleted", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UserPosition", "DateDeleted", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TemporaryLocationHourChange", "DateDeleted", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Position", "DateDeleted", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Shift", "DateDeleted", c => c.DateTime(nullable: false));
            AlterColumn("dbo.ScheduleSettings", "DateDeleted", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Schedule", "DateDeleted", c => c.DateTime(nullable: false));
            AlterColumn("dbo.ReceivablesSchedule", "DateDeleted", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Permission", "DateDeleted", c => c.DateTime(nullable: false));
            AlterColumn("dbo.NotificationMedia", "DateDeleted", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Notification", "DateDeleted", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Location", "DateDeleted", c => c.DateTime(nullable: false));
            AlterColumn("dbo.LeaveOfAbsence", "DateDeleted", c => c.DateTime(nullable: false));
            AlterColumn("dbo.HourChangeReason", "DateDeleted", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TimeZone", "DateDeleted", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Business", "DateDeleted", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Weekday", "DateDeleted", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Status", "DateDeleted", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Role", "DateDeleted", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Address", "DateDeleted", c => c.DateTime(nullable: false));
            AlterColumn("dbo.User", "DateDeleted", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Availability", "DateDeleted", c => c.DateTime(nullable: false));
        }
    }
}
