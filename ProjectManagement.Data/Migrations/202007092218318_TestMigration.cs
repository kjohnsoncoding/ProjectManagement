namespace ProjectManagement.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TestMigration : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Employee", "State");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employee", "State", c => c.String());
        }
    }
}
