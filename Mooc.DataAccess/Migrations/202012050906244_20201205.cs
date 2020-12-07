namespace Mooc.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _20201205 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.User", "Gender", c => c.String());
            AddColumn("dbo.User", "StudentNo", c => c.String());
            AddColumn("dbo.User", "Faulty", c => c.String());
            AddColumn("dbo.User", "Major", c => c.String());
            AddColumn("dbo.User", "CountryId", c => c.Int(nullable: false));
            AddColumn("dbo.User", "ProfessorGuid", c => c.String());
            AddColumn("dbo.User", "ProfessorId", c => c.Int(nullable: false));
            AddColumn("dbo.User", "PhotoFileName", c => c.String());
            AddColumn("dbo.User", "NickName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.User", "NickName");
            DropColumn("dbo.User", "PhotoFileName");
            DropColumn("dbo.User", "ProfessorId");
            DropColumn("dbo.User", "ProfessorGuid");
            DropColumn("dbo.User", "CountryId");
            DropColumn("dbo.User", "Major");
            DropColumn("dbo.User", "Faulty");
            DropColumn("dbo.User", "StudentNo");
            DropColumn("dbo.User", "Gender");
        }
    }
}
