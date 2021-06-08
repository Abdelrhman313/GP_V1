namespace Gp_V1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editEducationTable : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.SeekerRegistrations", "EducationId");
            DropColumn("dbo.SeekerRegistrations", "PreviousWorkId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SeekerRegistrations", "PreviousWorkId", c => c.Int(nullable: false));
            AddColumn("dbo.SeekerRegistrations", "EducationId", c => c.Int(nullable: false));
        }
    }
}
