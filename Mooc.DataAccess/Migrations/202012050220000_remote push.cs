namespace Mooc.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class remotepush : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.User", "Gender", c => c.String());
            DropTable("dbo.CreateOrUpdateUserDtoes");
            DropTable("dbo.UserDtoes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.UserDtoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        PassWord = c.String(),
                        Email = c.String(),
                        UserState = c.Int(nullable: false),
                        RoleType = c.Int(nullable: false),
                        AddTime = c.DateTime(),
                        Email111 = c.String(),
                        Gender = c.String(),
                        StudentNo = c.String(),
                        Faulty = c.String(),
                        Major = c.String(),
                        CountryId = c.Int(nullable: false),
                        ProfessorGuid = c.String(),
                        ProfessorId = c.Int(nullable: false),
                        PhotoFileName = c.String(),
                        NickName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CreateOrUpdateUserDtoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false, maxLength: 100),
                        PassWord = c.String(nullable: false, maxLength: 20),
                        Email = c.String(nullable: false),
                        UserState = c.Int(nullable: false),
                        RoleType = c.Int(nullable: false),
                        AddTime = c.DateTime(),
                        Gender = c.String(),
                        StudentNo = c.String(),
                        Faulty = c.String(),
                        Major = c.String(),
                        CountryId = c.Int(nullable: false),
                        ProfessorGuid = c.String(),
                        ProfessorId = c.Int(nullable: false),
                        PhotoFileName = c.String(),
                        NickName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AlterColumn("dbo.User", "Gender", c => c.String(nullable: false));
        }
    }
}
