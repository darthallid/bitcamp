namespace Shopping.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Type", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Type");
        }
    }
}
