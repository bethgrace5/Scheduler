namespace scheduler.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.User", "AddressId", "dbo.Address");
            DropForeignKey("dbo.Business", "BillingAddressId", "dbo.Address");
            DropForeignKey("dbo.Business", "HeadquarterAddressId", "dbo.Address");
            DropForeignKey("dbo.Location", "AddressId", "dbo.Address");
            DropPrimaryKey("dbo.Address");
            AlterColumn("dbo.Address", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Address", "Id");
            AddForeignKey("dbo.User", "AddressId", "dbo.Address", "Id", cascadeDelete: false);
            AddForeignKey("dbo.Business", "BillingAddressId", "dbo.Address", "Id", cascadeDelete: false);
            AddForeignKey("dbo.Business", "HeadquarterAddressId", "dbo.Address", "Id", cascadeDelete: false);
            AddForeignKey("dbo.Location", "AddressId", "dbo.Address", "Id", cascadeDelete: false);
            DropColumn("dbo.Address", "Name");
            DropColumn("dbo.Address", "Description");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Address", "Description", c => c.String());
            AddColumn("dbo.Address", "Name", c => c.String());
            DropForeignKey("dbo.Location", "AddressId", "dbo.Address");
            DropForeignKey("dbo.Business", "HeadquarterAddressId", "dbo.Address");
            DropForeignKey("dbo.Business", "BillingAddressId", "dbo.Address");
            DropForeignKey("dbo.User", "AddressId", "dbo.Address");
            DropPrimaryKey("dbo.Address");
            AlterColumn("dbo.Address", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Address", "Id");
            AddForeignKey("dbo.Location", "AddressId", "dbo.Address", "Id", cascadeDelete: false);
            AddForeignKey("dbo.Business", "HeadquarterAddressId", "dbo.Address", "Id", cascadeDelete: false);
            AddForeignKey("dbo.Business", "BillingAddressId", "dbo.Address", "Id", cascadeDelete: false);
            AddForeignKey("dbo.User", "AddressId", "dbo.Address", "Id", cascadeDelete: false);
        }
    }
}
