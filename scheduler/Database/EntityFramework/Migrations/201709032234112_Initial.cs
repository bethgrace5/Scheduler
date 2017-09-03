namespace scheduler.Database.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Availability",
                c => new
                    {
                        UserId = c.Int(nullable: false),
                        WeekdayId = c.Int(nullable: false),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        Id = c.Long(nullable: false),
                        IsEnabled = c.Boolean(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        DateDeleted = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserId, t.WeekdayId })
                .ForeignKey("dbo.User", t => t.Id, cascadeDelete: false)
                .ForeignKey("dbo.Weekday", t => t.Id, cascadeDelete: false)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Firstname = c.String(),
                        Lastname = c.String(),
                        Suffix = c.String(),
                        Email = c.String(),
                        Birthdate = c.DateTime(nullable: false),
                        MaxHoursPerWeek = c.Int(nullable: false),
                        MinHoursPerWeek = c.Int(nullable: false),
                        PrimaryPhone = c.String(),
                        SecondaryPhone = c.String(),
                        BusinessLedgerId = c.Int(nullable: false),
                        Notes = c.String(),
                        Active = c.Boolean(nullable: false),
                        RoleId = c.Int(nullable: false),
                        AddressId = c.Int(nullable: false),
                        StatusId = c.Int(nullable: false),
                        IsEnabled = c.Boolean(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        DateDeleted = c.DateTime(nullable: false),
                        Address_Id = c.Long(),
                        Role_Id = c.Long(),
                        Status_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Address", t => t.Address_Id)
                .ForeignKey("dbo.Role", t => t.Role_Id)
                .ForeignKey("dbo.Status", t => t.Status_Id)
                .Index(t => t.Address_Id)
                .Index(t => t.Role_Id)
                .Index(t => t.Status_Id);
            
            CreateTable(
                "dbo.Address",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Zipcode = c.Int(nullable: false),
                        Number = c.Int(nullable: false),
                        City = c.String(),
                        State = c.String(),
                        Street = c.String(),
                        IsEnabled = c.Boolean(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        DateDeleted = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Role",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        IsEnabled = c.Boolean(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        DateDeleted = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        IsEnabled = c.Boolean(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        DateDeleted = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Weekday",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        IsEnabled = c.Boolean(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        DateDeleted = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Business",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        PrimaryPhone = c.String(),
                        SecondaryPhone = c.String(),
                        Fax = c.String(),
                        SubscriptionEndDate = c.DateTime(nullable: false),
                        SignUpDate = c.DateTime(nullable: false),
                        TimeZoneId = c.Int(nullable: false),
                        BillingAddressId = c.Int(nullable: false),
                        HeadquarterAddressId = c.Int(nullable: false),
                        IsEnabled = c.Boolean(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        DateDeleted = c.DateTime(nullable: false),
                        BillingAddress_Id = c.Long(),
                        HeadquarterAddress_Id = c.Long(),
                        TimeZone_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Address", t => t.BillingAddress_Id)
                .ForeignKey("dbo.Address", t => t.HeadquarterAddress_Id)
                .ForeignKey("dbo.TimeZone", t => t.TimeZone_Id)
                .Index(t => t.BillingAddress_Id)
                .Index(t => t.HeadquarterAddress_Id)
                .Index(t => t.TimeZone_Id);
            
            CreateTable(
                "dbo.TimeZone",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        IsEnabled = c.Boolean(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        DateDeleted = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.HourChangeReason",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        IsEnabled = c.Boolean(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        DateDeleted = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LeaveOfAbsence",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        IsApproved = c.Boolean(nullable: false),
                        StartDateTime = c.DateTime(nullable: false),
                        EndDateTime = c.DateTime(nullable: false),
                        RequestedById = c.Int(nullable: false),
                        RespondedById = c.Int(nullable: false),
                        IsEnabled = c.Boolean(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        DateDeleted = c.DateTime(nullable: false),
                        RequestedBy_Id = c.Long(),
                        RespondedBy_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.RequestedBy_Id)
                .ForeignKey("dbo.User", t => t.RespondedBy_Id)
                .Index(t => t.RequestedBy_Id)
                .Index(t => t.RespondedBy_Id);
            
            CreateTable(
                "dbo.Location",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        PrimaryPhone = c.String(),
                        SecondaryPhone = c.String(),
                        Fax = c.String(),
                        TimeZoneId = c.Int(nullable: false),
                        BusinessId = c.Int(nullable: false),
                        AddressId = c.Int(nullable: false),
                        IsEnabled = c.Boolean(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        DateDeleted = c.DateTime(nullable: false),
                        Address_Id = c.Long(),
                        Business_Id = c.Long(),
                        TimeZone_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Address", t => t.Address_Id)
                .ForeignKey("dbo.Business", t => t.Business_Id)
                .ForeignKey("dbo.TimeZone", t => t.TimeZone_Id)
                .Index(t => t.Address_Id)
                .Index(t => t.Business_Id)
                .Index(t => t.TimeZone_Id);
            
            CreateTable(
                "dbo.Notification",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        IsEnabled = c.Boolean(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        DateDeleted = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.NotificationMedia",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        IsEnabled = c.Boolean(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        DateDeleted = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Permission",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        IsEnabled = c.Boolean(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        DateDeleted = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ReceivablesSchedule",
                c => new
                    {
                        Title = c.String(nullable: false, maxLength: 128),
                        Monday = c.Boolean(nullable: false),
                        Tuesday = c.Boolean(nullable: false),
                        Wednesday = c.Boolean(nullable: false),
                        Thursday = c.Boolean(nullable: false),
                        Friday = c.Boolean(nullable: false),
                        Saturday = c.Boolean(nullable: false),
                        Sunday = c.Boolean(nullable: false),
                        LocationId = c.Int(nullable: false),
                        Id = c.Long(nullable: false),
                        IsEnabled = c.Boolean(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        DateDeleted = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Title)
                .ForeignKey("dbo.Location", t => t.Id, cascadeDelete: false)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Schedule",
                c => new
                    {
                        LocationId = c.Int(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        DatePublished = c.DateTime(nullable: false),
                        PublishedById = c.Int(nullable: false),
                        Id = c.Long(nullable: false),
                        IsEnabled = c.Boolean(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        DateDeleted = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.LocationId, t.StartDate })
                .ForeignKey("dbo.Location", t => t.Id, cascadeDelete: false)
                .ForeignKey("dbo.User", t => t.Id, cascadeDelete: false)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.ScheduleSettings",
                c => new
                    {
                        BusinessId = c.Int(nullable: false, identity: true),
                        StartWeekdayId = c.Int(nullable: false),
                        Id = c.Long(nullable: false),
                        IsEnabled = c.Boolean(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        DateDeleted = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.BusinessId)
                .ForeignKey("dbo.Business", t => t.Id, cascadeDelete: false)
                .ForeignKey("dbo.Weekday", t => t.Id, cascadeDelete: false)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Shift",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        EffectiveDate = c.DateTime(nullable: false),
                        IneffectiveDate = c.DateTime(nullable: false),
                        MondayStart = c.DateTime(nullable: false),
                        MondayEnd = c.DateTime(nullable: false),
                        TuesdayStart = c.DateTime(nullable: false),
                        TuesdayEnd = c.DateTime(nullable: false),
                        WednesdayStart = c.DateTime(nullable: false),
                        WednesdayEnd = c.DateTime(nullable: false),
                        ThursdayStart = c.DateTime(nullable: false),
                        ThursdayEnd = c.DateTime(nullable: false),
                        FridayStart = c.DateTime(nullable: false),
                        FridayEnd = c.DateTime(nullable: false),
                        SaturdayStart = c.DateTime(nullable: false),
                        SaturdayEnd = c.DateTime(nullable: false),
                        SundayStart = c.DateTime(nullable: false),
                        SundayEnd = c.DateTime(nullable: false),
                        ViewIndex = c.Int(nullable: false),
                        PositionId = c.Int(nullable: false),
                        LocationId = c.Int(nullable: false),
                        IsEnabled = c.Boolean(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        DateDeleted = c.DateTime(nullable: false),
                        Location_Id = c.Long(),
                        Position_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Location", t => t.Location_Id)
                .ForeignKey("dbo.Position", t => t.Position_Id)
                .Index(t => t.Location_Id)
                .Index(t => t.Position_Id);
            
            CreateTable(
                "dbo.Position",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        IsEnabled = c.Boolean(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        DateDeleted = c.DateTime(nullable: false),
                        User_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.TemporaryLocationHourChange",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        StartDateTime = c.DateTime(nullable: false),
                        EndDateTime = c.DateTime(nullable: false),
                        ReasonId = c.String(),
                        IsOpen = c.Boolean(nullable: false),
                        HourChangeReasonId = c.Int(nullable: false),
                        LocationId = c.Int(nullable: false),
                        IsEnabled = c.Boolean(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        DateDeleted = c.DateTime(nullable: false),
                        HourChangeReason_Id = c.Long(),
                        Location_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.HourChangeReason", t => t.HourChangeReason_Id)
                .ForeignKey("dbo.Location", t => t.Location_Id)
                .Index(t => t.HourChangeReason_Id)
                .Index(t => t.Location_Id);
            
            CreateTable(
                "dbo.UserLocationHistory",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        DateEmployed = c.DateTime(nullable: false),
                        DateUnemployed = c.DateTime(nullable: false),
                        LocationId = c.Int(nullable: false),
                        Location_Id = c.Long(),
                        User_Id = c.Long(),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.Location", t => t.Location_Id)
                .ForeignKey("dbo.User", t => t.User_Id)
                .Index(t => t.Location_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.UserNotificationSettings",
                c => new
                    {
                        UserId = c.Int(nullable: false),
                        NotificaitonId = c.Int(nullable: false),
                        MediaId = c.Int(nullable: false),
                        Notification_Id = c.Long(),
                        NotificationMedia_Id = c.Long(),
                        User_Id = c.Long(),
                    })
                .PrimaryKey(t => new { t.UserId, t.NotificaitonId, t.MediaId })
                .ForeignKey("dbo.Notification", t => t.Notification_Id)
                .ForeignKey("dbo.NotificationMedia", t => t.NotificationMedia_Id)
                .ForeignKey("dbo.User", t => t.User_Id)
                .Index(t => t.Notification_Id)
                .Index(t => t.NotificationMedia_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.UserPermission",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        PermissionId = c.Int(nullable: false),
                        Permission_Id = c.Long(),
                        User_Id = c.Long(),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.Permission", t => t.Permission_Id)
                .ForeignKey("dbo.User", t => t.User_Id)
                .Index(t => t.Permission_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.UserPosition",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        IsPrimary = c.Boolean(nullable: false),
                        IsTraining = c.Boolean(nullable: false),
                        PositionId = c.Int(nullable: false),
                        Id = c.Long(nullable: false),
                        IsEnabled = c.Boolean(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        DateDeleted = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.Position", t => t.Id, cascadeDelete: false)
                .ForeignKey("dbo.User", t => t.Id, cascadeDelete: false)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.UserScheduledForShift",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        UserId = c.Int(nullable: false),
                        ShiftId = c.Int(nullable: false),
                        Shift_Id = c.Long(),
                        User_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Shift", t => t.Shift_Id)
                .ForeignKey("dbo.User", t => t.User_Id)
                .Index(t => t.Shift_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.UserStatus",
                c => new
                    {
                        UserId = c.Int(nullable: false),
                        StatusId = c.Int(nullable: false),
                        Status_Id = c.Long(),
                        User_Id = c.Long(),
                    })
                .PrimaryKey(t => new { t.UserId, t.StatusId })
                .ForeignKey("dbo.Status", t => t.Status_Id)
                .ForeignKey("dbo.User", t => t.User_Id)
                .Index(t => t.Status_Id)
                .Index(t => t.User_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserStatus", "User_Id", "dbo.User");
            DropForeignKey("dbo.UserStatus", "Status_Id", "dbo.Status");
            DropForeignKey("dbo.UserScheduledForShift", "User_Id", "dbo.User");
            DropForeignKey("dbo.UserScheduledForShift", "Shift_Id", "dbo.Shift");
            DropForeignKey("dbo.UserPosition", "Id", "dbo.User");
            DropForeignKey("dbo.UserPosition", "Id", "dbo.Position");
            DropForeignKey("dbo.UserPermission", "User_Id", "dbo.User");
            DropForeignKey("dbo.UserPermission", "Permission_Id", "dbo.Permission");
            DropForeignKey("dbo.UserNotificationSettings", "User_Id", "dbo.User");
            DropForeignKey("dbo.UserNotificationSettings", "NotificationMedia_Id", "dbo.NotificationMedia");
            DropForeignKey("dbo.UserNotificationSettings", "Notification_Id", "dbo.Notification");
            DropForeignKey("dbo.UserLocationHistory", "User_Id", "dbo.User");
            DropForeignKey("dbo.UserLocationHistory", "Location_Id", "dbo.Location");
            DropForeignKey("dbo.TemporaryLocationHourChange", "Location_Id", "dbo.Location");
            DropForeignKey("dbo.TemporaryLocationHourChange", "HourChangeReason_Id", "dbo.HourChangeReason");
            DropForeignKey("dbo.Shift", "Position_Id", "dbo.Position");
            DropForeignKey("dbo.Position", "User_Id", "dbo.User");
            DropForeignKey("dbo.Shift", "Location_Id", "dbo.Location");
            DropForeignKey("dbo.ScheduleSettings", "Id", "dbo.Weekday");
            DropForeignKey("dbo.ScheduleSettings", "Id", "dbo.Business");
            DropForeignKey("dbo.Schedule", "Id", "dbo.User");
            DropForeignKey("dbo.Schedule", "Id", "dbo.Location");
            DropForeignKey("dbo.ReceivablesSchedule", "Id", "dbo.Location");
            DropForeignKey("dbo.Location", "TimeZone_Id", "dbo.TimeZone");
            DropForeignKey("dbo.Location", "Business_Id", "dbo.Business");
            DropForeignKey("dbo.Location", "Address_Id", "dbo.Address");
            DropForeignKey("dbo.LeaveOfAbsence", "RespondedBy_Id", "dbo.User");
            DropForeignKey("dbo.LeaveOfAbsence", "RequestedBy_Id", "dbo.User");
            DropForeignKey("dbo.Business", "TimeZone_Id", "dbo.TimeZone");
            DropForeignKey("dbo.Business", "HeadquarterAddress_Id", "dbo.Address");
            DropForeignKey("dbo.Business", "BillingAddress_Id", "dbo.Address");
            DropForeignKey("dbo.Availability", "Id", "dbo.Weekday");
            DropForeignKey("dbo.Availability", "Id", "dbo.User");
            DropForeignKey("dbo.User", "Status_Id", "dbo.Status");
            DropForeignKey("dbo.User", "Role_Id", "dbo.Role");
            DropForeignKey("dbo.User", "Address_Id", "dbo.Address");
            DropIndex("dbo.UserStatus", new[] { "User_Id" });
            DropIndex("dbo.UserStatus", new[] { "Status_Id" });
            DropIndex("dbo.UserScheduledForShift", new[] { "User_Id" });
            DropIndex("dbo.UserScheduledForShift", new[] { "Shift_Id" });
            DropIndex("dbo.UserPosition", new[] { "Id" });
            DropIndex("dbo.UserPermission", new[] { "User_Id" });
            DropIndex("dbo.UserPermission", new[] { "Permission_Id" });
            DropIndex("dbo.UserNotificationSettings", new[] { "User_Id" });
            DropIndex("dbo.UserNotificationSettings", new[] { "NotificationMedia_Id" });
            DropIndex("dbo.UserNotificationSettings", new[] { "Notification_Id" });
            DropIndex("dbo.UserLocationHistory", new[] { "User_Id" });
            DropIndex("dbo.UserLocationHistory", new[] { "Location_Id" });
            DropIndex("dbo.TemporaryLocationHourChange", new[] { "Location_Id" });
            DropIndex("dbo.TemporaryLocationHourChange", new[] { "HourChangeReason_Id" });
            DropIndex("dbo.Position", new[] { "User_Id" });
            DropIndex("dbo.Shift", new[] { "Position_Id" });
            DropIndex("dbo.Shift", new[] { "Location_Id" });
            DropIndex("dbo.ScheduleSettings", new[] { "Id" });
            DropIndex("dbo.Schedule", new[] { "Id" });
            DropIndex("dbo.ReceivablesSchedule", new[] { "Id" });
            DropIndex("dbo.Location", new[] { "TimeZone_Id" });
            DropIndex("dbo.Location", new[] { "Business_Id" });
            DropIndex("dbo.Location", new[] { "Address_Id" });
            DropIndex("dbo.LeaveOfAbsence", new[] { "RespondedBy_Id" });
            DropIndex("dbo.LeaveOfAbsence", new[] { "RequestedBy_Id" });
            DropIndex("dbo.Business", new[] { "TimeZone_Id" });
            DropIndex("dbo.Business", new[] { "HeadquarterAddress_Id" });
            DropIndex("dbo.Business", new[] { "BillingAddress_Id" });
            DropIndex("dbo.User", new[] { "Status_Id" });
            DropIndex("dbo.User", new[] { "Role_Id" });
            DropIndex("dbo.User", new[] { "Address_Id" });
            DropIndex("dbo.Availability", new[] { "Id" });
            DropTable("dbo.UserStatus");
            DropTable("dbo.UserScheduledForShift");
            DropTable("dbo.UserPosition");
            DropTable("dbo.UserPermission");
            DropTable("dbo.UserNotificationSettings");
            DropTable("dbo.UserLocationHistory");
            DropTable("dbo.TemporaryLocationHourChange");
            DropTable("dbo.Position");
            DropTable("dbo.Shift");
            DropTable("dbo.ScheduleSettings");
            DropTable("dbo.Schedule");
            DropTable("dbo.ReceivablesSchedule");
            DropTable("dbo.Permission");
            DropTable("dbo.NotificationMedia");
            DropTable("dbo.Notification");
            DropTable("dbo.Location");
            DropTable("dbo.LeaveOfAbsence");
            DropTable("dbo.HourChangeReason");
            DropTable("dbo.TimeZone");
            DropTable("dbo.Business");
            DropTable("dbo.Weekday");
            DropTable("dbo.Status");
            DropTable("dbo.Role");
            DropTable("dbo.Address");
            DropTable("dbo.User");
            DropTable("dbo.Availability");
        }
    }
}
