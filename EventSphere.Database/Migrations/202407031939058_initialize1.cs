namespace EventSphere.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialize1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SocietyDetails", "SocietyID", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SocietyDetails", "SocietyID");
        }
    }
}
