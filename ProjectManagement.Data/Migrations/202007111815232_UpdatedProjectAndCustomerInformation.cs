namespace ProjectManagement.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedProjectAndCustomerInformation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customer", "CustomerType", c => c.Int(nullable: false));
            AddColumn("dbo.Project", "Equipment", c => c.Int(nullable: false));
            AddColumn("dbo.Project", "Vehicle", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Project", "Vehicle");
            DropColumn("dbo.Project", "Equipment");
            DropColumn("dbo.Customer", "CustomerType");
        }
    }
}
