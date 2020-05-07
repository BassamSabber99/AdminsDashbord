namespace Admins.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatephone : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "phone", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "phone", c => c.Int(nullable: false));
        }
    }
}
