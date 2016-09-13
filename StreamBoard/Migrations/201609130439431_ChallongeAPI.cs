namespace StreamBoard.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChallongeAPI : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "ChallongeAPI", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "ChallongeAPI");
        }
    }
}
