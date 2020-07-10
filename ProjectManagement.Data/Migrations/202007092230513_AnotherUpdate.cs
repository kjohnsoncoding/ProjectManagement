namespace ProjectManagement.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AnotherUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employee", "State", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employee", "State");
        }
    }
}
