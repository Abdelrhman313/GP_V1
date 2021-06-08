namespace Gp_V1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateEducationTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SeekerRegistrations", "EducationId", c => c.Int(nullable: false));
            AddColumn("dbo.SeekerRegistrations", "PreviousWorkId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SeekerRegistrations", "PreviousWorkId");
            DropColumn("dbo.SeekerRegistrations", "EducationId");
        }
    }
}
