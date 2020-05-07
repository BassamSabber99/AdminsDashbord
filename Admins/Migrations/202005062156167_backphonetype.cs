namespace Admins.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class backphonetype : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "phone", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "phone", c => c.String(nullable: false));
        }
    }
}
