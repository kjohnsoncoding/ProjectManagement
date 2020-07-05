namespace ProjectManagement.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedEmployeeMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employee", "Name", c => c.String());
            DropColumn("dbo.Employee", "FirstName");
            DropColumn("dbo.Employee", "LastName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employee", "LastName", c => c.String());
            AddColumn("dbo.Employee", "FirstName", c => c.String());
            DropColumn("dbo.Employee", "Name");
        }
    }
}
