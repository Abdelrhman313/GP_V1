namespace Gp_V1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditSeekerRegistration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.SeekerRegistrations", "SeekerImage", c => c.String(nullable: false));
            AlterColumn("dbo.SeekerRegistrations", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.SeekerRegistrations", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.SeekerRegistrations", "Password", c => c.String(nullable: false));
            AlterColumn("dbo.SeekerRegistrations", "Gender", c => c.String(nullable: false));
            AlterColumn("dbo.SeekerRegistrations", "SearchOnJobTitle", c => c.String(nullable: false));
            AlterColumn("dbo.SeekerRegistrations", "CompanyName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SeekerRegistrations", "CompanyName", c => c.String());
            AlterColumn("dbo.SeekerRegistrations", "SearchOnJobTitle", c => c.String());
            AlterColumn("dbo.SeekerRegistrations", "Gender", c => c.String());
            AlterColumn("dbo.SeekerRegistrations", "Password", c => c.String());
            AlterColumn("dbo.SeekerRegistrations", "Email", c => c.String());
            AlterColumn("dbo.SeekerRegistrations", "Name", c => c.String());
            AlterColumn("dbo.SeekerRegistrations", "SeekerImage", c => c.String());
        }
    }
}
