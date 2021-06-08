namespace Gp_V1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditTables : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Educations", "EducationLevelId", "dbo.EducationLevels");
            DropForeignKey("dbo.Educations", "LanguageId", "dbo.Languages");
            DropForeignKey("dbo.Educations", "UniversityId", "dbo.Universities");
            DropForeignKey("dbo.Educations", "Id", "dbo.SeekerRegistrations");
            DropForeignKey("dbo.PreviousWorks", "JobCategoryId", "dbo.JobCategories");
            DropForeignKey("dbo.PreviousWorks", "JobTitleId", "dbo.JobTitles");
            DropForeignKey("dbo.PreviousWorks", "JobTypeId", "dbo.JobTypes");
            DropForeignKey("dbo.PreviousWorks", "Id", "dbo.SeekerRegistrations");
            DropIndex("dbo.Educations", new[] { "Id" });
            DropIndex("dbo.Educations", new[] { "LanguageId" });
            DropIndex("dbo.Educations", new[] { "UniversityId" });
            DropIndex("dbo.Educations", new[] { "EducationLevelId" });
            DropIndex("dbo.PreviousWorks", new[] { "Id" });
            DropIndex("dbo.PreviousWorks", new[] { "JobTitleId" });
            DropIndex("dbo.PreviousWorks", new[] { "JobTypeId" });
            DropIndex("dbo.PreviousWorks", new[] { "JobCategoryId" });
            AddColumn("dbo.SeekerRegistrations", "SearchOnJobTitle", c => c.String());
            AddColumn("dbo.SeekerRegistrations", "CompanyName", c => c.String());
            AddColumn("dbo.SeekerRegistrations", "Salary", c => c.Int(nullable: false));
            AddColumn("dbo.SeekerRegistrations", "Duration", c => c.Int(nullable: false));
            AddColumn("dbo.SeekerRegistrations", "JobTitleId", c => c.Int(nullable: false));
            AddColumn("dbo.SeekerRegistrations", "JobTypeId", c => c.Int(nullable: false));
            AddColumn("dbo.SeekerRegistrations", "JobCategoryId", c => c.Int(nullable: false));
            AddColumn("dbo.SeekerRegistrations", "GraduationDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.SeekerRegistrations", "LanguageId", c => c.Int(nullable: false));
            AddColumn("dbo.SeekerRegistrations", "UniversityId", c => c.Int(nullable: false));
            AddColumn("dbo.SeekerRegistrations", "EducationLevelId", c => c.Int(nullable: false));
            CreateIndex("dbo.SeekerRegistrations", "JobTitleId");
            CreateIndex("dbo.SeekerRegistrations", "JobTypeId");
            CreateIndex("dbo.SeekerRegistrations", "JobCategoryId");
            CreateIndex("dbo.SeekerRegistrations", "LanguageId");
            CreateIndex("dbo.SeekerRegistrations", "UniversityId");
            CreateIndex("dbo.SeekerRegistrations", "EducationLevelId");
            AddForeignKey("dbo.SeekerRegistrations", "EducationLevelId", "dbo.EducationLevels", "Id", cascadeDelete: true);
            AddForeignKey("dbo.SeekerRegistrations", "JobCategoryId", "dbo.JobCategories", "Id", cascadeDelete: false);
            AddForeignKey("dbo.SeekerRegistrations", "JobTitleId", "dbo.JobTitles", "Id", cascadeDelete: false);
            AddForeignKey("dbo.SeekerRegistrations", "JobTypeId", "dbo.JobTypes", "Id", cascadeDelete: false);
            AddForeignKey("dbo.SeekerRegistrations", "LanguageId", "dbo.Languages", "Id", cascadeDelete: true);
            AddForeignKey("dbo.SeekerRegistrations", "UniversityId", "dbo.Universities", "Id", cascadeDelete: true);
            DropColumn("dbo.SeekerRegistrations", "JobTitle");
            DropTable("dbo.Educations");
            DropTable("dbo.PreviousWorks");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.PreviousWorks",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        CompanyName = c.String(),
                        Salary = c.Int(nullable: false),
                        Duration = c.Int(nullable: false),
                        JobTitleId = c.Int(nullable: false),
                        JobTypeId = c.Int(nullable: false),
                        JobCategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Educations",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        GraduationDate = c.DateTime(nullable: false),
                        LanguageId = c.Int(nullable: false),
                        UniversityId = c.Int(nullable: false),
                        EducationLevelId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.SeekerRegistrations", "JobTitle", c => c.String());
            DropForeignKey("dbo.SeekerRegistrations", "UniversityId", "dbo.Universities");
            DropForeignKey("dbo.SeekerRegistrations", "LanguageId", "dbo.Languages");
            DropForeignKey("dbo.SeekerRegistrations", "JobTypeId", "dbo.JobTypes");
            DropForeignKey("dbo.SeekerRegistrations", "JobTitleId", "dbo.JobTitles");
            DropForeignKey("dbo.SeekerRegistrations", "JobCategoryId", "dbo.JobCategories");
            DropForeignKey("dbo.SeekerRegistrations", "EducationLevelId", "dbo.EducationLevels");
            DropIndex("dbo.SeekerRegistrations", new[] { "EducationLevelId" });
            DropIndex("dbo.SeekerRegistrations", new[] { "UniversityId" });
            DropIndex("dbo.SeekerRegistrations", new[] { "LanguageId" });
            DropIndex("dbo.SeekerRegistrations", new[] { "JobCategoryId" });
            DropIndex("dbo.SeekerRegistrations", new[] { "JobTypeId" });
            DropIndex("dbo.SeekerRegistrations", new[] { "JobTitleId" });
            DropColumn("dbo.SeekerRegistrations", "EducationLevelId");
            DropColumn("dbo.SeekerRegistrations", "UniversityId");
            DropColumn("dbo.SeekerRegistrations", "LanguageId");
            DropColumn("dbo.SeekerRegistrations", "GraduationDate");
            DropColumn("dbo.SeekerRegistrations", "JobCategoryId");
            DropColumn("dbo.SeekerRegistrations", "JobTypeId");
            DropColumn("dbo.SeekerRegistrations", "JobTitleId");
            DropColumn("dbo.SeekerRegistrations", "Duration");
            DropColumn("dbo.SeekerRegistrations", "Salary");
            DropColumn("dbo.SeekerRegistrations", "CompanyName");
            DropColumn("dbo.SeekerRegistrations", "SearchOnJobTitle");
            CreateIndex("dbo.PreviousWorks", "JobCategoryId");
            CreateIndex("dbo.PreviousWorks", "JobTypeId");
            CreateIndex("dbo.PreviousWorks", "JobTitleId");
            CreateIndex("dbo.PreviousWorks", "Id");
            CreateIndex("dbo.Educations", "EducationLevelId");
            CreateIndex("dbo.Educations", "UniversityId");
            CreateIndex("dbo.Educations", "LanguageId");
            CreateIndex("dbo.Educations", "Id");
            AddForeignKey("dbo.PreviousWorks", "Id", "dbo.SeekerRegistrations", "Id");
            AddForeignKey("dbo.PreviousWorks", "JobTypeId", "dbo.JobTypes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.PreviousWorks", "JobTitleId", "dbo.JobTitles", "Id", cascadeDelete: true);
            AddForeignKey("dbo.PreviousWorks", "JobCategoryId", "dbo.JobCategories", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Educations", "Id", "dbo.SeekerRegistrations", "Id");
            AddForeignKey("dbo.Educations", "UniversityId", "dbo.Universities", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Educations", "LanguageId", "dbo.Languages", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Educations", "EducationLevelId", "dbo.EducationLevels", "Id", cascadeDelete: true);
        }
    }
}
