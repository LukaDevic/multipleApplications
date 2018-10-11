namespace MultipleApplications.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DodateKarakteristikeKlasiNaplata : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Naplatas", "DaLiKoristiAkciju", c => c.Boolean(nullable: false));
            AddColumn("dbo.Naplatas", "AkcijskaCena", c => c.Int(nullable: false));
            AddColumn("dbo.Naplatas", "PlacenoSve", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Naplatas", "PlacenoSve");
            DropColumn("dbo.Naplatas", "AkcijskaCena");
            DropColumn("dbo.Naplatas", "DaLiKoristiAkciju");
        }
    }
}
