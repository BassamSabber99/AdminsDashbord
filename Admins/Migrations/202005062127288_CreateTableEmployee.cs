namespace Admins.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableEmployee : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        id = c.Byte(nullable: false),
                        hrCode = c.Int(nullable: false),
                        name = c.String(nullable: false),
                        image = c.String(nullable: false),
                        phone = c.Int(nullable: false),
                        password = c.String(nullable: false),
                        address = c.String(nullable: false),
                        title = c.String(nullable: false),
                        deparetmentId = c.Byte(nullable: false),
                        Department_id = c.Byte(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Departments", t => t.Department_id)
                .Index(t => t.Department_id);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        id = c.Byte(nullable: false),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "Department_id", "dbo.Departments");
            DropIndex("dbo.Employees", new[] { "Department_id" });
            DropTable("dbo.Departments");
            DropTable("dbo.Employees");
        }
    }
}
