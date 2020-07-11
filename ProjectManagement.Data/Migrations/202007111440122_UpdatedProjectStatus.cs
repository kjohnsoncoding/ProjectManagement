namespace ProjectManagement.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedProjectStatus : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Project", "ProjectStatus", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Project", "ProjectStatus", c => c.Boolean(nullable: false));
        }
    }
}
