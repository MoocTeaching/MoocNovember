namespace Mooc.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IntiDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(nullable: false, maxLength: 200),
                        Age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false, maxLength: 200),
                        PassWord = c.String(nullable: false, maxLength: 200),
                        Email = c.String(maxLength: 200),
                        UserState = c.Int(nullable: false),
                        RoleType = c.Int(nullable: false),
                        AddTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.User");
            DropTable("dbo.Student");
        }
    }
}
