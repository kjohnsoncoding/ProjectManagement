namespace ProjectManagement.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class YetAnotherUpdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customer", "State", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customer", "State", c => c.String());
        }
    }
}
