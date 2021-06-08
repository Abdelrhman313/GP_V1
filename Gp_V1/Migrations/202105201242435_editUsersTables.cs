namespace Gp_V1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editUsersTables : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RegisterUsers", "SecurityQuestion", c => c.String());
            AddColumn("dbo.SeekerRegistrations", "SecurityQuestion", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.SeekerRegistrations", "SecurityQuestion");
            DropColumn("dbo.RegisterUsers", "SecurityQuestion");
        }
    }
}
