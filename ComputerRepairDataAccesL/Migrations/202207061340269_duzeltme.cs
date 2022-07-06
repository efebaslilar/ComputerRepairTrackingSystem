namespace ComputerRepairDataAccesL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class duzeltme : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ComputerRepairs", "PersonId", "dbo.Persons");
            DropIndex("dbo.ComputerRepairs", new[] { "PersonId" });
            AddColumn("dbo.ComputerRepairs", "PersonName", c => c.String());
            AddColumn("dbo.ComputerRepairs", "PersonPhone", c => c.String());
            AddColumn("dbo.ComputerRepairs", "Problem", c => c.String());
            DropColumn("dbo.ComputerRepairs", "PersonId");
            DropColumn("dbo.ComputerRepairs", "Promblem");
            DropTable("dbo.Persons");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Persons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameSurname = c.String(),
                        PhoneNumber = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.ComputerRepairs", "Promblem", c => c.String());
            AddColumn("dbo.ComputerRepairs", "PersonId", c => c.Int(nullable: false));
            DropColumn("dbo.ComputerRepairs", "Problem");
            DropColumn("dbo.ComputerRepairs", "PersonPhone");
            DropColumn("dbo.ComputerRepairs", "PersonName");
            CreateIndex("dbo.ComputerRepairs", "PersonId");
            AddForeignKey("dbo.ComputerRepairs", "PersonId", "dbo.Persons", "Id", cascadeDelete: true);
        }
    }
}
