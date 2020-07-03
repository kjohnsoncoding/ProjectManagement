namespace ProjectManagement.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customer", "Name", c => c.String());
            AddColumn("dbo.Customer", "Address", c => c.String());
            AddColumn("dbo.Customer", "City", c => c.String());
            AddColumn("dbo.Customer", "State", c => c.String());
            AddColumn("dbo.Customer", "PhoneNumber", c => c.String());
            AddColumn("dbo.Customer", "EmailAddress", c => c.String());
            DropColumn("dbo.Customer", "CustomerName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customer", "CustomerName", c => c.String(nullable: false));
            DropColumn("dbo.Customer", "EmailAddress");
            DropColumn("dbo.Customer", "PhoneNumber");
            DropColumn("dbo.Customer", "State");
            DropColumn("dbo.Customer", "City");
            DropColumn("dbo.Customer", "Address");
            DropColumn("dbo.Customer", "Name");
        }
    }
}
