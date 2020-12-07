namespace Mooc.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inttolong : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.User", "ProfessorId", c => c.Long(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.User", "ProfessorId", c => c.Int(nullable: false));
        }
    }
}
