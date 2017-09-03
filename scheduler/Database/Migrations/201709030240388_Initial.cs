namespace scheduler.Database.Migrations
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
                    })
                .PrimaryKey(t => new { t.UserId, t.WeekdayId })
                .ForeignKey("dbo.User", t => t.UserId, cascadeDelete: false)
                .ForeignKey("dbo.Weekday", t => t.WeekdayId, cascadeDelete: false)
                .Index(t => t.UserId)
                .Index(t => t.WeekdayId);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Firstname = c.String(),
                        Lastname = c.String(),
                        Suffix = c.String(),
                        Email = c.String(),
                        Birthdate = c.DateTime(nullable: false),
                        MaxHoursPerWeek = c.Int(nullable: false),
                        MinHoursPerWeek = c.Int(nullable: false),
                        AddressId = c.Int(nullable: false),
                        PrimaryPhone = c.String(),
                        SecondaryPhone = c.String(),
                        BusinessLedgerId = c.Int(nullable: false),
                        RoleId = c.Int(nullable: false),
                        Notes = c.String(),
                        Active = c.Boolean(nullable: false),
                        StatusId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Address", t => t.AddressId, cascadeDelete: false)
                .ForeignKey("dbo.Role", t => t.RoleId, cascadeDelete: false)
                .ForeignKey("dbo.Status", t => t.StatusId, cascadeDelete: false)
                .Index(t => t.AddressId)
                .Index(t => t.RoleId)
                .Index(t => t.StatusId);
            
            CreateTable(
                "dbo.Address",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Zipcode = c.Int(nullable: false),
                        Number = c.Int(nullable: false),
                        City = c.String(),
                        State = c.String(),
                        Street = c.String(),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Role",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Weekday",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Business",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TimeZoneId = c.Int(nullable: false),
                        BillingAddressId = c.Int(nullable: false),
                        HeadquarterAddressId = c.Int(nullable: false),
                        Name = c.String(),
                        PrimaryPhone = c.String(),
                        SecondaryPhone = c.String(),
                        Fax = c.String(),
                        SubscriptionEndDate = c.DateTime(nullable: false),
                        SignUpDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Address", t => t.BillingAddressId, cascadeDelete: false)
                .ForeignKey("dbo.Address", t => t.HeadquarterAddressId, cascadeDelete: false)
                .ForeignKey("dbo.TimeZone", t => t.TimeZoneId, cascadeDelete: false)
                .Index(t => t.TimeZoneId)
                .Index(t => t.BillingAddressId)
                .Index(t => t.HeadquarterAddressId);
            
            CreateTable(
                "dbo.TimeZone",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.HourChangeReason",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LeaveOfAbsence",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RequestedById = c.Int(nullable: false),
                        RespondedById = c.Int(nullable: false),
                        IsApproved = c.Boolean(nullable: false),
                        StartDateTime = c.DateTime(nullable: false),
                        EndDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.RequestedById, cascadeDelete: false)
                .ForeignKey("dbo.User", t => t.RespondedById, cascadeDelete: false)
                .Index(t => t.RequestedById)
                .Index(t => t.RespondedById);
            
            CreateTable(
                "dbo.Location",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BusinessId = c.Int(nullable: false),
                        TimeZoneId = c.Int(nullable: false),
                        AddressId = c.Int(nullable: false),
                        Name = c.String(),
                        PrimaryPhone = c.String(),
                        SecondaryPhone = c.String(),
                        Fax = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Address", t => t.AddressId, cascadeDelete: false)
                .ForeignKey("dbo.Business", t => t.BusinessId, cascadeDelete: false)
                .ForeignKey("dbo.TimeZone", t => t.TimeZoneId, cascadeDelete: false)
                .Index(t => t.BusinessId)
                .Index(t => t.TimeZoneId)
                .Index(t => t.AddressId);
            
            CreateTable(
                "dbo.Notification",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.NotificationMedia",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Permission",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ReceivablesSchedule",
                c => new
                    {
                        Title = c.String(nullable: false, maxLength: 128),
                        LocationId = c.Int(nullable: false),
                        Monday = c.Boolean(nullable: false),
                        Tuesday = c.Boolean(nullable: false),
                        Wednesday = c.Boolean(nullable: false),
                        Thursday = c.Boolean(nullable: false),
                        Friday = c.Boolean(nullable: false),
                        Saturday = c.Boolean(nullable: false),
                        Sunday = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Title)
                .ForeignKey("dbo.Location", t => t.LocationId, cascadeDelete: false)
                .Index(t => t.LocationId);
            
            CreateTable(
                "dbo.Schedule",
                c => new
                    {
                        LocationId = c.Int(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        PublishedById = c.Int(nullable: false),
                        DatePublished = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.LocationId, t.StartDate })
                .ForeignKey("dbo.Location", t => t.LocationId, cascadeDelete: false)
                .ForeignKey("dbo.User", t => t.PublishedById, cascadeDelete: false)
                .Index(t => t.LocationId)
                .Index(t => t.PublishedById);
            
            CreateTable(
                "dbo.ScheduleSettings",
                c => new
                    {
                        BusinessId = c.Int(nullable: false, identity: true),
                        StartWeekdayId = c.Int(nullable: false),
                        Business_Id = c.Int(),
                    })
                .PrimaryKey(t => t.BusinessId)
                .ForeignKey("dbo.Business", t => t.Business_Id)
                .ForeignKey("dbo.Weekday", t => t.StartWeekdayId, cascadeDelete: false)
                .Index(t => t.StartWeekdayId)
                .Index(t => t.Business_Id);
            
            CreateTable(
                "dbo.Shift",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PositionId = c.Int(nullable: false),
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
                        LocationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Location", t => t.LocationId, cascadeDelete: false)
                .ForeignKey("dbo.Position", t => t.PositionId, cascadeDelete: false)
                .Index(t => t.PositionId)
                .Index(t => t.LocationId);
            
            CreateTable(
                "dbo.Position",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TemporaryLocationHourChange",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StartDateTime = c.DateTime(nullable: false),
                        EndDateTime = c.DateTime(nullable: false),
                        ReasonId = c.String(),
                        LocationId = c.Int(nullable: false),
                        IsOpen = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Location", t => t.LocationId, cascadeDelete: false)
                .Index(t => t.LocationId);
            
            CreateTable(
                "dbo.UserLocationHistory",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        DateEmployed = c.DateTime(nullable: false),
                        DateUnemployed = c.DateTime(nullable: false),
                        LocationId = c.Int(nullable: false),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.Location", t => t.LocationId, cascadeDelete: false)
                .ForeignKey("dbo.User", t => t.User_Id)
                .Index(t => t.LocationId)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.UserNotificationSettings",
                c => new
                    {
                        UserId = c.Int(nullable: false),
                        NotificaitonId = c.Int(nullable: false),
                        MediaId = c.Int(nullable: false),
                        Notification_Id = c.Int(),
                        NotificationMedia_Id = c.Int(),
                    })
                .PrimaryKey(t => new { t.UserId, t.NotificaitonId, t.MediaId })
                .ForeignKey("dbo.Notification", t => t.Notification_Id)
                .ForeignKey("dbo.NotificationMedia", t => t.NotificationMedia_Id)
                .ForeignKey("dbo.User", t => t.UserId, cascadeDelete: false)
                .Index(t => t.UserId)
                .Index(t => t.Notification_Id)
                .Index(t => t.NotificationMedia_Id);
            
            CreateTable(
                "dbo.UserPermission",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        PermissionId = c.Int(nullable: false),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.Permission", t => t.PermissionId, cascadeDelete: false)
                .ForeignKey("dbo.User", t => t.User_Id)
                .Index(t => t.PermissionId)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.UserPosition",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        PositionId = c.Int(nullable: false),
                        DateAcquired = c.DateTime(nullable: false),
                        DateRemoved = c.DateTime(nullable: false),
                        IsPrimary = c.Boolean(nullable: false),
                        IsTraining = c.Boolean(nullable: false),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.Position", t => t.PositionId, cascadeDelete: false)
                .ForeignKey("dbo.User", t => t.User_Id)
                .Index(t => t.PositionId)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.UserScheduledForShift",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        ShiftId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Shift", t => t.ShiftId, cascadeDelete: false)
                .ForeignKey("dbo.User", t => t.UserId, cascadeDelete: false)
                .Index(t => t.UserId)
                .Index(t => t.ShiftId);
            
            CreateTable(
                "dbo.UserStatus",
                c => new
                    {
                        UserId = c.Int(nullable: false),
                        StatusId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserId, t.StatusId })
                .ForeignKey("dbo.Status", t => t.StatusId, cascadeDelete: false)
                .ForeignKey("dbo.User", t => t.UserId, cascadeDelete: false)
                .Index(t => t.UserId)
                .Index(t => t.StatusId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserStatus", "UserId", "dbo.User");
            DropForeignKey("dbo.UserStatus", "StatusId", "dbo.Status");
            DropForeignKey("dbo.UserScheduledForShift", "UserId", "dbo.User");
            DropForeignKey("dbo.UserScheduledForShift", "ShiftId", "dbo.Shift");
            DropForeignKey("dbo.UserPosition", "User_Id", "dbo.User");
            DropForeignKey("dbo.UserPosition", "PositionId", "dbo.Position");
            DropForeignKey("dbo.UserPermission", "User_Id", "dbo.User");
            DropForeignKey("dbo.UserPermission", "PermissionId", "dbo.Permission");
            DropForeignKey("dbo.UserNotificationSettings", "UserId", "dbo.User");
            DropForeignKey("dbo.UserNotificationSettings", "NotificationMedia_Id", "dbo.NotificationMedia");
            DropForeignKey("dbo.UserNotificationSettings", "Notification_Id", "dbo.Notification");
            DropForeignKey("dbo.UserLocationHistory", "User_Id", "dbo.User");
            DropForeignKey("dbo.UserLocationHistory", "LocationId", "dbo.Location");
            DropForeignKey("dbo.TemporaryLocationHourChange", "LocationId", "dbo.Location");
            DropForeignKey("dbo.Shift", "PositionId", "dbo.Position");
            DropForeignKey("dbo.Shift", "LocationId", "dbo.Location");
            DropForeignKey("dbo.ScheduleSettings", "StartWeekdayId", "dbo.Weekday");
            DropForeignKey("dbo.ScheduleSettings", "Business_Id", "dbo.Business");
            DropForeignKey("dbo.Schedule", "PublishedById", "dbo.User");
            DropForeignKey("dbo.Schedule", "LocationId", "dbo.Location");
            DropForeignKey("dbo.ReceivablesSchedule", "LocationId", "dbo.Location");
            DropForeignKey("dbo.Location", "TimeZoneId", "dbo.TimeZone");
            DropForeignKey("dbo.Location", "BusinessId", "dbo.Business");
            DropForeignKey("dbo.Location", "AddressId", "dbo.Address");
            DropForeignKey("dbo.LeaveOfAbsence", "RespondedById", "dbo.User");
            DropForeignKey("dbo.LeaveOfAbsence", "RequestedById", "dbo.User");
            DropForeignKey("dbo.Business", "TimeZoneId", "dbo.TimeZone");
            DropForeignKey("dbo.Business", "HeadquarterAddressId", "dbo.Address");
            DropForeignKey("dbo.Business", "BillingAddressId", "dbo.Address");
            DropForeignKey("dbo.Availability", "WeekdayId", "dbo.Weekday");
            DropForeignKey("dbo.Availability", "UserId", "dbo.User");
            DropForeignKey("dbo.User", "StatusId", "dbo.Status");
            DropForeignKey("dbo.User", "RoleId", "dbo.Role");
            DropForeignKey("dbo.User", "AddressId", "dbo.Address");
            DropIndex("dbo.UserStatus", new[] { "StatusId" });
            DropIndex("dbo.UserStatus", new[] { "UserId" });
            DropIndex("dbo.UserScheduledForShift", new[] { "ShiftId" });
            DropIndex("dbo.UserScheduledForShift", new[] { "UserId" });
            DropIndex("dbo.UserPosition", new[] { "User_Id" });
            DropIndex("dbo.UserPosition", new[] { "PositionId" });
            DropIndex("dbo.UserPermission", new[] { "User_Id" });
            DropIndex("dbo.UserPermission", new[] { "PermissionId" });
            DropIndex("dbo.UserNotificationSettings", new[] { "NotificationMedia_Id" });
            DropIndex("dbo.UserNotificationSettings", new[] { "Notification_Id" });
            DropIndex("dbo.UserNotificationSettings", new[] { "UserId" });
            DropIndex("dbo.UserLocationHistory", new[] { "User_Id" });
            DropIndex("dbo.UserLocationHistory", new[] { "LocationId" });
            DropIndex("dbo.TemporaryLocationHourChange", new[] { "LocationId" });
            DropIndex("dbo.Shift", new[] { "LocationId" });
            DropIndex("dbo.Shift", new[] { "PositionId" });
            DropIndex("dbo.ScheduleSettings", new[] { "Business_Id" });
            DropIndex("dbo.ScheduleSettings", new[] { "StartWeekdayId" });
            DropIndex("dbo.Schedule", new[] { "PublishedById" });
            DropIndex("dbo.Schedule", new[] { "LocationId" });
            DropIndex("dbo.ReceivablesSchedule", new[] { "LocationId" });
            DropIndex("dbo.Location", new[] { "AddressId" });
            DropIndex("dbo.Location", new[] { "TimeZoneId" });
            DropIndex("dbo.Location", new[] { "BusinessId" });
            DropIndex("dbo.LeaveOfAbsence", new[] { "RespondedById" });
            DropIndex("dbo.LeaveOfAbsence", new[] { "RequestedById" });
            DropIndex("dbo.Business", new[] { "HeadquarterAddressId" });
            DropIndex("dbo.Business", new[] { "BillingAddressId" });
            DropIndex("dbo.Business", new[] { "TimeZoneId" });
            DropIndex("dbo.User", new[] { "StatusId" });
            DropIndex("dbo.User", new[] { "RoleId" });
            DropIndex("dbo.User", new[] { "AddressId" });
            DropIndex("dbo.Availability", new[] { "WeekdayId" });
            DropIndex("dbo.Availability", new[] { "UserId" });
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
