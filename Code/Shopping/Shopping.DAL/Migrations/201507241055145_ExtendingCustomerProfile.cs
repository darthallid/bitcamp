namespace Shopping.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ExtendingCustomerProfile : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "CityId", "dbo.Cities");
            DropIndex("dbo.Customers", new[] { "CityId" });
            AddColumn("dbo.CustomerProfiles", "Address", c => c.String(nullable: false, maxLength: 100));
            AddColumn("dbo.CustomerProfiles", "PhoneNumber", c => c.String(nullable: false, maxLength: 20));
            AddColumn("dbo.CustomerProfiles", "CityId", c => c.Int(nullable: false));
            AddColumn("dbo.CustomerProfiles", "Type", c => c.Int(nullable: false));
            CreateIndex("dbo.CustomerProfiles", "CityId");
            AddForeignKey("dbo.CustomerProfiles", "CityId", "dbo.Cities", "Id", cascadeDelete: true);
            DropColumn("dbo.Customers", "Address");
            DropColumn("dbo.Customers", "PhoneNumber");
            DropColumn("dbo.Customers", "Type");
            DropColumn("dbo.Customers", "CityId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "CityId", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "Type", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "PhoneNumber", c => c.String(nullable: false, maxLength: 20));
            AddColumn("dbo.Customers", "Address", c => c.String(nullable: false, maxLength: 100));
            DropForeignKey("dbo.CustomerProfiles", "CityId", "dbo.Cities");
            DropIndex("dbo.CustomerProfiles", new[] { "CityId" });
            DropColumn("dbo.CustomerProfiles", "Type");
            DropColumn("dbo.CustomerProfiles", "CityId");
            DropColumn("dbo.CustomerProfiles", "PhoneNumber");
            DropColumn("dbo.CustomerProfiles", "Address");
            CreateIndex("dbo.Customers", "CityId");
            AddForeignKey("dbo.Customers", "CityId", "dbo.Cities", "Id", cascadeDelete: true);
        }
    }
}
