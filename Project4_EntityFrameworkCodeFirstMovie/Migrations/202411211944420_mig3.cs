namespace Project4_EntityFrameworkCodeFirstMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Duration", c => c.Int(nullable: false));
            DropColumn("dbo.Movies", "Deration");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "Deration", c => c.Int(nullable: false));
            DropColumn("dbo.Movies", "Duration");
        }
    }
}
