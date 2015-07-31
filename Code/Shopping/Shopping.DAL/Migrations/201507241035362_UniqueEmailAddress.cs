namespace Shopping.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UniqueEmailAddress : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "EmailAddress", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.Customers", "EmailAddress", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Customers", new[] { "EmailAddress" });
            DropColumn("dbo.Customers", "EmailAddress");
        }
    }
}
