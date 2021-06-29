namespace Gp_V1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addpropseekercv : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SeekerRegistrations", "SeekerCV", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.SeekerRegistrations", "SeekerCV");
        }
    }
}
