namespace ProjectManagement.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customer", "OwnerId", c => c.Guid(nullable: false));
            AddColumn("dbo.Customer", "CustomerAdded", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.Customer", "LastUpdated", c => c.DateTimeOffset(precision: 7));
            AddColumn("dbo.Employee", "OwnerId", c => c.Guid(nullable: false));
            AddColumn("dbo.Employee", "EmployeeCreated", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.Employee", "LastUpdated", c => c.DateTimeOffset(precision: 7));
            AddColumn("dbo.Project", "OwnerId", c => c.Guid(nullable: false));
            AddColumn("dbo.Project", "ProjectUpdated", c => c.DateTimeOffset(precision: 7));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Project", "ProjectUpdated");
            DropColumn("dbo.Project", "OwnerId");
            DropColumn("dbo.Employee", "LastUpdated");
            DropColumn("dbo.Employee", "EmployeeCreated");
            DropColumn("dbo.Employee", "OwnerId");
            DropColumn("dbo.Customer", "LastUpdated");
            DropColumn("dbo.Customer", "CustomerAdded");
            DropColumn("dbo.Customer", "OwnerId");
        }
    }
}
