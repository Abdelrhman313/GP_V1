namespace Gp_V1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateEducationTable2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Educations", "EducationLevelId", "dbo.EducationLevels");
            DropIndex("dbo.Educations", new[] { "EducationLevelId" });
            AddColumn("dbo.Educations", "CareerLevel", c => c.String());
            DropColumn("dbo.Educations", "EducationLevelId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Educations", "EducationLevelId", c => c.Int(nullable: false));
            DropColumn("dbo.Educations", "CareerLevel");
            CreateIndex("dbo.Educations", "EducationLevelId");
            AddForeignKey("dbo.Educations", "EducationLevelId", "dbo.EducationLevels", "Id", cascadeDelete: true);
        }
    }
}
