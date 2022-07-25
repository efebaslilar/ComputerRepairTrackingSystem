namespace ComputerRepairDataAccesL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class son : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ComputerRepairs", "BrandId", "dbo.Brands");
            DropIndex("dbo.ComputerRepairs", new[] { "BrandId" });
            AddColumn("dbo.ComputerRepairs", "Brand", c => c.String());
            AddColumn("dbo.ComputerRepairs", "Price", c => c.Int(nullable: false));
            DropColumn("dbo.ComputerRepairs", "BrandId");
            DropTable("dbo.Brands");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Brands",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.ComputerRepairs", "BrandId", c => c.Int(nullable: false));
            DropColumn("dbo.ComputerRepairs", "Price");
            DropColumn("dbo.ComputerRepairs", "Brand");
            CreateIndex("dbo.ComputerRepairs", "BrandId");
            AddForeignKey("dbo.ComputerRepairs", "BrandId", "dbo.Brands", "Id", cascadeDelete: true);
        }
    }
}
