namespace Registeration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class teamdetails : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TeamMembers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        teamtitle = c.String(),
                        FullName1 = c.String(),
                        University1 = c.String(),
                        Phone1 = c.String(),
                        Email1 = c.String(),
                        DOB1 = c.DateTime(nullable: false),
                        FullName2 = c.String(),
                        University2 = c.String(),
                        Phone2 = c.String(),
                        Email2 = c.String(),
                        DOB2 = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TeamMembers");
        }
    }
}
