namespace MultipleApplications.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changesInDatatablesRelation : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Naplatas", "CustomerId", "dbo.Customers");
            DropIndex("dbo.Naplatas", new[] { "CustomerId" });
            AddColumn("dbo.Customers", "NaplataId", c => c.Int(nullable: false));
            CreateIndex("dbo.Customers", "NaplataId");
            AddForeignKey("dbo.Customers", "NaplataId", "dbo.Naplatas", "Id", cascadeDelete: true);
            DropColumn("dbo.Naplatas", "CustomerId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Naplatas", "CustomerId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Customers", "NaplataId", "dbo.Naplatas");
            DropIndex("dbo.Customers", new[] { "NaplataId" });
            DropColumn("dbo.Customers", "NaplataId");
            CreateIndex("dbo.Naplatas", "CustomerId");
            AddForeignKey("dbo.Naplatas", "CustomerId", "dbo.Customers", "Id", cascadeDelete: true);
        }
    }
}
