namespace Shopping.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerProfiles : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CustomerProfiles",
                c => new
                    {
                        Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CustomerProfiles", "Id", "dbo.Customers");
            DropIndex("dbo.CustomerProfiles", new[] { "Id" });
            DropTable("dbo.CustomerProfiles");
        }
    }
}
