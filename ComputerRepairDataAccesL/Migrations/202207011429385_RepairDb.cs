namespace ComputerRepairDataAccesL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RepairDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Brands",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ComputerRepairs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PersonId = c.Int(nullable: false),
                        BrandId = c.Int(nullable: false),
                        Promblem = c.String(),
                        RecordOfDateTime = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Brands", t => t.BrandId, cascadeDelete: true)
                .ForeignKey("dbo.Persons", t => t.PersonId, cascadeDelete: true)
                .Index(t => t.PersonId)
                .Index(t => t.BrandId);
            
            CreateTable(
                "dbo.Persons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameSurname = c.String(),
                        PhoneNumber = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ComputerRepairs", "PersonId", "dbo.Persons");
            DropForeignKey("dbo.ComputerRepairs", "BrandId", "dbo.Brands");
            DropIndex("dbo.ComputerRepairs", new[] { "BrandId" });
            DropIndex("dbo.ComputerRepairs", new[] { "PersonId" });
            DropTable("dbo.Persons");
            DropTable("dbo.ComputerRepairs");
            DropTable("dbo.Brands");
        }
    }
}
