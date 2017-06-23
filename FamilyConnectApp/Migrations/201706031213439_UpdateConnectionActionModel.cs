namespace FamilyConnectApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateConnectionActionModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ConnectionActions", "UserId", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ConnectionActions", "UserId");
        }
    }
}
