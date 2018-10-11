namespace MultipleApplications.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedModeltoOnlyContainCustomers : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "NaplataId", "dbo.Naplatas");
            DropIndex("dbo.Customers", new[] { "NaplataId" });
            AddColumn("dbo.Customers", "TeorijskaObuka", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "TeorijskiIspit", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "PrakticnaObuka", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "PrakticanIspit", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "BrojDodatnihCasova", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "PlacenoZaDodatneCasove", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "DaLiKoristiAkciju", c => c.Boolean(nullable: false));
            AddColumn("dbo.Customers", "AkcijskaCena", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "PlacenoSve", c => c.Boolean(nullable: false));
            DropColumn("dbo.Customers", "NaplataId");
            DropTable("dbo.Naplatas");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Naplatas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TeorijskaObuka = c.Int(nullable: false),
                        TeorijskiIspit = c.Int(nullable: false),
                        PrakticnaObuka = c.Int(nullable: false),
                        PrakticanIspit = c.Int(nullable: false),
                        BrojDodatnihCasova = c.Int(nullable: false),
                        PlacenoZaDodatneCasove = c.Int(nullable: false),
                        DaLiKoristiAkciju = c.Boolean(nullable: false),
                        AkcijskaCena = c.Int(nullable: false),
                        PlacenoSve = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Customers", "NaplataId", c => c.Int(nullable: false));
            DropColumn("dbo.Customers", "PlacenoSve");
            DropColumn("dbo.Customers", "AkcijskaCena");
            DropColumn("dbo.Customers", "DaLiKoristiAkciju");
            DropColumn("dbo.Customers", "PlacenoZaDodatneCasove");
            DropColumn("dbo.Customers", "BrojDodatnihCasova");
            DropColumn("dbo.Customers", "PrakticanIspit");
            DropColumn("dbo.Customers", "PrakticnaObuka");
            DropColumn("dbo.Customers", "TeorijskiIspit");
            DropColumn("dbo.Customers", "TeorijskaObuka");
            CreateIndex("dbo.Customers", "NaplataId");
            AddForeignKey("dbo.Customers", "NaplataId", "dbo.Naplatas", "Id", cascadeDelete: true);
        }
    }
}
