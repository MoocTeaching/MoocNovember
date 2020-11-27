namespace Mooc.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class userUpdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Student", "Name", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.User", "UserName", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.User", "PassWord", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.User", "Email", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.User", "Email", c => c.String(maxLength: 200));
            AlterColumn("dbo.User", "PassWord", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.User", "UserName", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.Student", "Name", c => c.String(nullable: false, maxLength: 200));
        }
    }
}
