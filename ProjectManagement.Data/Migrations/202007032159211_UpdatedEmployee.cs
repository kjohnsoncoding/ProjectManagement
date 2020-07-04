namespace ProjectManagement.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedEmployee : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employee", "Address", c => c.String());
            AddColumn("dbo.Employee", "City", c => c.String());
            AddColumn("dbo.Employee", "State", c => c.String());
            AddColumn("dbo.Employee", "PhoneNumber", c => c.String());
            AddColumn("dbo.Employee", "EmailAddress", c => c.String());
            AlterColumn("dbo.Employee", "FirstName", c => c.String());
            AlterColumn("dbo.Employee", "LastName", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employee", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.Employee", "FirstName", c => c.String(nullable: false));
            DropColumn("dbo.Employee", "EmailAddress");
            DropColumn("dbo.Employee", "PhoneNumber");
            DropColumn("dbo.Employee", "State");
            DropColumn("dbo.Employee", "City");
            DropColumn("dbo.Employee", "Address");
        }
    }
}
