namespace Gp_V1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateEducationTable3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Educations", "EducationLevelId", c => c.Int(nullable: false));
            CreateIndex("dbo.Educations", "EducationLevelId");
            AddForeignKey("dbo.Educations", "EducationLevelId", "dbo.EducationLevels", "Id", cascadeDelete: true);
            DropColumn("dbo.Educations", "CareerLevel");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Educations", "CareerLevel", c => c.String());
            DropForeignKey("dbo.Educations", "EducationLevelId", "dbo.EducationLevels");
            DropIndex("dbo.Educations", new[] { "EducationLevelId" });
            DropColumn("dbo.Educations", "EducationLevelId");
        }
    }
}
