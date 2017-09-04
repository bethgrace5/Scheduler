namespace scheduler.Infrastructure.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial3 : DbMigration
    {
        public override void Up()
        {
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
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UsStatesAndTerritories");
            DropTable("dbo.Language");
            DropTable("dbo.Country");
        }
    }
}
