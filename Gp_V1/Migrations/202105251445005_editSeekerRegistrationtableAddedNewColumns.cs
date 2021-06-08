namespace Gp_V1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editSeekerRegistrationtableAddedNewColumns : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SeekerRegistrations", "CurrentCompanyName", c => c.String());
            AddColumn("dbo.SeekerRegistrations", "CurrentSalary", c => c.Int(nullable: false));
            AddColumn("dbo.SeekerRegistrations", "CurrentDuration", c => c.Int(nullable: false));
            AddColumn("dbo.SeekerRegistrations", "CurrentJobTitle", c => c.String());
            AddColumn("dbo.SeekerRegistrations", "CurrentJobType", c => c.String());
            AddColumn("dbo.SeekerRegistrations", "CurrentJobCategory", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.SeekerRegistrations", "CurrentJobCategory");
            DropColumn("dbo.SeekerRegistrations", "CurrentJobType");
            DropColumn("dbo.SeekerRegistrations", "CurrentJobTitle");
            DropColumn("dbo.SeekerRegistrations", "CurrentDuration");
            DropColumn("dbo.SeekerRegistrations", "CurrentSalary");
            DropColumn("dbo.SeekerRegistrations", "CurrentCompanyName");
        }
    }
}
