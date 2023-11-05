namespace Registeration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addfilecoloum : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TeamMembers", "Userfile2", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.TeamMembers", "Userfile2");
        }
    }
}
