namespace Registeration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addcolumn : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Files",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FileUrl = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.TeamMembers", "Userfile", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.TeamMembers", "Userfile");
            DropTable("dbo.Files");
        }
    }
}
