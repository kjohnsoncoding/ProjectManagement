namespace ProjectManagement.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangesMadeToEmployeesAndCustomers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customer", "Customer_CustomerId", c => c.Int());
            AddColumn("dbo.Employee", "Employee_EmployeeId", c => c.Int());
            AlterColumn("dbo.Customer", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Customer", "Address", c => c.String(nullable: false));
            AlterColumn("dbo.Customer", "City", c => c.String(nullable: false));
            AlterColumn("dbo.Customer", "PhoneNumber", c => c.String(nullable: false));
            AlterColumn("dbo.Customer", "EmailAddress", c => c.String(nullable: false));
            AlterColumn("dbo.Employee", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Employee", "Address", c => c.String(nullable: false));
            AlterColumn("dbo.Employee", "City", c => c.String(nullable: false));
            AlterColumn("dbo.Employee", "PhoneNumber", c => c.String(nullable: false));
            AlterColumn("dbo.Employee", "EmailAddress", c => c.String(nullable: false));
            CreateIndex("dbo.Customer", "Customer_CustomerId");
            CreateIndex("dbo.Employee", "Employee_EmployeeId");
            AddForeignKey("dbo.Customer", "Customer_CustomerId", "dbo.Customer", "CustomerId");
            AddForeignKey("dbo.Employee", "Employee_EmployeeId", "dbo.Employee", "EmployeeId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employee", "Employee_EmployeeId", "dbo.Employee");
            DropForeignKey("dbo.Customer", "Customer_CustomerId", "dbo.Customer");
            DropIndex("dbo.Employee", new[] { "Employee_EmployeeId" });
            DropIndex("dbo.Customer", new[] { "Customer_CustomerId" });
            AlterColumn("dbo.Employee", "EmailAddress", c => c.String());
            AlterColumn("dbo.Employee", "PhoneNumber", c => c.String());
            AlterColumn("dbo.Employee", "City", c => c.String());
            AlterColumn("dbo.Employee", "Address", c => c.String());
            AlterColumn("dbo.Employee", "Name", c => c.String());
            AlterColumn("dbo.Customer", "EmailAddress", c => c.String());
            AlterColumn("dbo.Customer", "PhoneNumber", c => c.String());
            AlterColumn("dbo.Customer", "City", c => c.String());
            AlterColumn("dbo.Customer", "Address", c => c.String());
            AlterColumn("dbo.Customer", "Name", c => c.String());
            DropColumn("dbo.Employee", "Employee_EmployeeId");
            DropColumn("dbo.Customer", "Customer_CustomerId");
        }
    }
}
