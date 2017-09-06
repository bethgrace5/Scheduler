namespace scheduler.Infrastructure.Database.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Address",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Number = c.Int(nullable: false),
                        Street = c.String(),
                        City = c.String(),
                        State = c.String(),
                        Zipcode = c.Int(nullable: false),
                        IsEnabled = c.Boolean(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        DateDeleted = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Availability",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        IsEnabled = c.Boolean(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        DateDeleted = c.DateTime(),
                        User_Id = c.Long(),
                        Weekday_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.User_Id)
                .ForeignKey("dbo.Weekday", t => t.Weekday_Id)
                .Index(t => t.User_Id)
                .Index(t => t.Weekday_Id);
            
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
                        IsEnabled = c.Boolean(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        DateDeleted = c.DateTime(),
                        Address_Id = c.Long(),
                        Position_Id = c.Long(),
                        Role_Id = c.Long(),
                        Status_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Address", t => t.Address_Id)
                .ForeignKey("dbo.Position", t => t.Position_Id)
                .ForeignKey("dbo.Role", t => t.Role_Id)
                .ForeignKey("dbo.Status", t => t.Status_Id)
                .Index(t => t.Address_Id)
                .Index(t => t.Position_Id)
                .Index(t => t.Role_Id)
                .Index(t => t.Status_Id);
            
            CreateTable(
                "dbo.LocationHistory",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        DateEmployed = c.DateTime(nullable: false),
                        DateUnemployed = c.DateTime(nullable: false),
                        IsEnabled = c.Boolean(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        DateDeleted = c.DateTime(),
                        Location_Id = c.Long(),
                        User_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Location", t => t.Location_Id)
                .ForeignKey("dbo.User", t => t.User_Id)
                .Index(t => t.Location_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Location",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        PrimaryPhone = c.String(),
                        SecondaryPhone = c.String(),
                        Fax = c.String(),
                        IsEnabled = c.Boolean(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        DateDeleted = c.DateTime(),
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
                        IsEnabled = c.Boolean(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        DateDeleted = c.DateTime(),
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
                        DateDeleted = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Position",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        Area = c.String(),
                        IsEnabled = c.Boolean(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        DateDeleted = c.DateTime(),
                        Location_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Location", t => t.Location_Id)
                .Index(t => t.Location_Id);
            
            CreateTable(
                "dbo.TemporaryLocationHourChange",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        StartDateTime = c.DateTime(nullable: false),
                        EndDateTime = c.DateTime(nullable: false),
                        IsOpen = c.Boolean(nullable: false),
                        IsEnabled = c.Boolean(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        DateDeleted = c.DateTime(),
                        HourChangeReason_Id = c.Long(),
                        Location_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.HourChangeReason", t => t.HourChangeReason_Id)
                .ForeignKey("dbo.Location", t => t.Location_Id)
                .Index(t => t.HourChangeReason_Id)
                .Index(t => t.Location_Id);
            
            CreateTable(
                "dbo.HourChangeReason",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        IsEnabled = c.Boolean(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        DateDeleted = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.NotificationSettings",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        IsEnabled = c.Boolean(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        DateDeleted = c.DateTime(),
                        Notification_Id = c.Long(),
                        NotificationMedia_Id = c.Long(),
                        User_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Notification", t => t.Notification_Id)
                .ForeignKey("dbo.NotificationMedia", t => t.NotificationMedia_Id)
                .ForeignKey("dbo.User", t => t.User_Id)
                .Index(t => t.Notification_Id)
                .Index(t => t.NotificationMedia_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Notification",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        IsEnabled = c.Boolean(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        DateDeleted = c.DateTime(),
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
                        DateDeleted = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Permission",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        IsEnabled = c.Boolean(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        DateDeleted = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.HasPosition",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        IsPrimary = c.Boolean(nullable: false),
                        IsTraining = c.Boolean(nullable: false),
                        IsEnabled = c.Boolean(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        DateDeleted = c.DateTime(),
                        Position_Id = c.Long(),
                        User_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Position", t => t.Position_Id)
                .ForeignKey("dbo.User", t => t.User_Id)
                .Index(t => t.Position_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Role",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        IsEnabled = c.Boolean(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        DateDeleted = c.DateTime(),
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
                        DateDeleted = c.DateTime(),
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
                        DateDeleted = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Country",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        IsEnabled = c.Boolean(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        DateDeleted = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Language",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        IsEnabled = c.Boolean(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        DateDeleted = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Absence",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        IsApproved = c.Boolean(nullable: false),
                        StartDateTime = c.DateTime(nullable: false),
                        EndDateTime = c.DateTime(nullable: false),
                        IsEnabled = c.Boolean(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        DateDeleted = c.DateTime(),
                        RequestedBy_Id = c.Long(),
                        RespondedBy_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.RequestedBy_Id)
                .ForeignKey("dbo.User", t => t.RespondedBy_Id)
                .Index(t => t.RequestedBy_Id)
                .Index(t => t.RespondedBy_Id);
            
            CreateTable(
                "dbo.Receivable",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Title = c.String(),
                        Monday = c.Boolean(nullable: false),
                        Tuesday = c.Boolean(nullable: false),
                        Wednesday = c.Boolean(nullable: false),
                        Thursday = c.Boolean(nullable: false),
                        Friday = c.Boolean(nullable: false),
                        Saturday = c.Boolean(nullable: false),
                        Sunday = c.Boolean(nullable: false),
                        IsEnabled = c.Boolean(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        DateDeleted = c.DateTime(),
                        Location_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Location", t => t.Location_Id)
                .Index(t => t.Location_Id);
            
            CreateTable(
                "dbo.Schedule",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        StartDate = c.DateTime(nullable: false),
                        DatePublished = c.DateTime(nullable: false),
                        IsEnabled = c.Boolean(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        DateDeleted = c.DateTime(),
                        Location_Id = c.Long(),
                        PublishedBy_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Location", t => t.Location_Id)
                .ForeignKey("dbo.User", t => t.PublishedBy_Id)
                .Index(t => t.Location_Id)
                .Index(t => t.PublishedBy_Id);
            
            CreateTable(
                "dbo.ScheduleSettings",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        IsEnabled = c.Boolean(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        DateDeleted = c.DateTime(),
                        Business_Id = c.Long(),
                        StartWeekday_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Business", t => t.Business_Id)
                .ForeignKey("dbo.Weekday", t => t.StartWeekday_Id)
                .Index(t => t.Business_Id)
                .Index(t => t.StartWeekday_Id);
            
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
                        IsEnabled = c.Boolean(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        DateDeleted = c.DateTime(),
                        Location_Id = c.Long(),
                        Position_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Location", t => t.Location_Id)
                .ForeignKey("dbo.Position", t => t.Position_Id)
                .Index(t => t.Location_Id)
                .Index(t => t.Position_Id);
            
            CreateTable(
                "dbo.UserScheduledForShift",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        IsEnabled = c.Boolean(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        DateDeleted = c.DateTime(),
                        Shift_Id = c.Long(),
                        User_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Shift", t => t.Shift_Id)
                .ForeignKey("dbo.User", t => t.User_Id)
                .Index(t => t.Shift_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.UsStatesAndTerritories",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        IsEnabled = c.Boolean(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        DateDeleted = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PermissionUser",
                c => new
                    {
                        Permission_Id = c.Long(nullable: false),
                        User_Id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => new { t.Permission_Id, t.User_Id })
                .ForeignKey("dbo.Permission", t => t.Permission_Id, cascadeDelete: true)
                .ForeignKey("dbo.User", t => t.User_Id, cascadeDelete: true)
                .Index(t => t.Permission_Id)
                .Index(t => t.User_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserScheduledForShift", "User_Id", "dbo.User");
            DropForeignKey("dbo.UserScheduledForShift", "Shift_Id", "dbo.Shift");
            DropForeignKey("dbo.Shift", "Position_Id", "dbo.Position");
            DropForeignKey("dbo.Shift", "Location_Id", "dbo.Location");
            DropForeignKey("dbo.ScheduleSettings", "StartWeekday_Id", "dbo.Weekday");
            DropForeignKey("dbo.ScheduleSettings", "Business_Id", "dbo.Business");
            DropForeignKey("dbo.Schedule", "PublishedBy_Id", "dbo.User");
            DropForeignKey("dbo.Schedule", "Location_Id", "dbo.Location");
            DropForeignKey("dbo.Receivable", "Location_Id", "dbo.Location");
            DropForeignKey("dbo.Absence", "RespondedBy_Id", "dbo.User");
            DropForeignKey("dbo.Absence", "RequestedBy_Id", "dbo.User");
            DropForeignKey("dbo.Availability", "Weekday_Id", "dbo.Weekday");
            DropForeignKey("dbo.User", "Status_Id", "dbo.Status");
            DropForeignKey("dbo.User", "Role_Id", "dbo.Role");
            DropForeignKey("dbo.HasPosition", "User_Id", "dbo.User");
            DropForeignKey("dbo.HasPosition", "Position_Id", "dbo.Position");
            DropForeignKey("dbo.PermissionUser", "User_Id", "dbo.User");
            DropForeignKey("dbo.PermissionUser", "Permission_Id", "dbo.Permission");
            DropForeignKey("dbo.NotificationSettings", "User_Id", "dbo.User");
            DropForeignKey("dbo.NotificationSettings", "NotificationMedia_Id", "dbo.NotificationMedia");
            DropForeignKey("dbo.NotificationSettings", "Notification_Id", "dbo.Notification");
            DropForeignKey("dbo.LocationHistory", "User_Id", "dbo.User");
            DropForeignKey("dbo.LocationHistory", "Location_Id", "dbo.Location");
            DropForeignKey("dbo.Location", "TimeZone_Id", "dbo.TimeZone");
            DropForeignKey("dbo.TemporaryLocationHourChange", "Location_Id", "dbo.Location");
            DropForeignKey("dbo.TemporaryLocationHourChange", "HourChangeReason_Id", "dbo.HourChangeReason");
            DropForeignKey("dbo.User", "Position_Id", "dbo.Position");
            DropForeignKey("dbo.Position", "Location_Id", "dbo.Location");
            DropForeignKey("dbo.Location", "Business_Id", "dbo.Business");
            DropForeignKey("dbo.Business", "TimeZone_Id", "dbo.TimeZone");
            DropForeignKey("dbo.Business", "HeadquarterAddress_Id", "dbo.Address");
            DropForeignKey("dbo.Business", "BillingAddress_Id", "dbo.Address");
            DropForeignKey("dbo.Location", "Address_Id", "dbo.Address");
            DropForeignKey("dbo.Availability", "User_Id", "dbo.User");
            DropForeignKey("dbo.User", "Address_Id", "dbo.Address");
            DropIndex("dbo.PermissionUser", new[] { "User_Id" });
            DropIndex("dbo.PermissionUser", new[] { "Permission_Id" });
            DropIndex("dbo.UserScheduledForShift", new[] { "User_Id" });
            DropIndex("dbo.UserScheduledForShift", new[] { "Shift_Id" });
            DropIndex("dbo.Shift", new[] { "Position_Id" });
            DropIndex("dbo.Shift", new[] { "Location_Id" });
            DropIndex("dbo.ScheduleSettings", new[] { "StartWeekday_Id" });
            DropIndex("dbo.ScheduleSettings", new[] { "Business_Id" });
            DropIndex("dbo.Schedule", new[] { "PublishedBy_Id" });
            DropIndex("dbo.Schedule", new[] { "Location_Id" });
            DropIndex("dbo.Receivable", new[] { "Location_Id" });
            DropIndex("dbo.Absence", new[] { "RespondedBy_Id" });
            DropIndex("dbo.Absence", new[] { "RequestedBy_Id" });
            DropIndex("dbo.HasPosition", new[] { "User_Id" });
            DropIndex("dbo.HasPosition", new[] { "Position_Id" });
            DropIndex("dbo.NotificationSettings", new[] { "User_Id" });
            DropIndex("dbo.NotificationSettings", new[] { "NotificationMedia_Id" });
            DropIndex("dbo.NotificationSettings", new[] { "Notification_Id" });
            DropIndex("dbo.TemporaryLocationHourChange", new[] { "Location_Id" });
            DropIndex("dbo.TemporaryLocationHourChange", new[] { "HourChangeReason_Id" });
            DropIndex("dbo.Position", new[] { "Location_Id" });
            DropIndex("dbo.Business", new[] { "TimeZone_Id" });
            DropIndex("dbo.Business", new[] { "HeadquarterAddress_Id" });
            DropIndex("dbo.Business", new[] { "BillingAddress_Id" });
            DropIndex("dbo.Location", new[] { "TimeZone_Id" });
            DropIndex("dbo.Location", new[] { "Business_Id" });
            DropIndex("dbo.Location", new[] { "Address_Id" });
            DropIndex("dbo.LocationHistory", new[] { "User_Id" });
            DropIndex("dbo.LocationHistory", new[] { "Location_Id" });
            DropIndex("dbo.User", new[] { "Status_Id" });
            DropIndex("dbo.User", new[] { "Role_Id" });
            DropIndex("dbo.User", new[] { "Position_Id" });
            DropIndex("dbo.User", new[] { "Address_Id" });
            DropIndex("dbo.Availability", new[] { "Weekday_Id" });
            DropIndex("dbo.Availability", new[] { "User_Id" });
            DropTable("dbo.PermissionUser");
            DropTable("dbo.UsStatesAndTerritories");
            DropTable("dbo.UserScheduledForShift");
            DropTable("dbo.Shift");
            DropTable("dbo.ScheduleSettings");
            DropTable("dbo.Schedule");
            DropTable("dbo.Receivable");
            DropTable("dbo.Absence");
            DropTable("dbo.Language");
            DropTable("dbo.Country");
            DropTable("dbo.Weekday");
            DropTable("dbo.Status");
            DropTable("dbo.Role");
            DropTable("dbo.HasPosition");
            DropTable("dbo.Permission");
            DropTable("dbo.NotificationMedia");
            DropTable("dbo.Notification");
            DropTable("dbo.NotificationSettings");
            DropTable("dbo.HourChangeReason");
            DropTable("dbo.TemporaryLocationHourChange");
            DropTable("dbo.Position");
            DropTable("dbo.TimeZone");
            DropTable("dbo.Business");
            DropTable("dbo.Location");
            DropTable("dbo.LocationHistory");
            DropTable("dbo.User");
            DropTable("dbo.Availability");
            DropTable("dbo.Address");
        }
    }
}
