namespace ComputerRepairDataAccesL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sonn : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ComputerRepairs", "Price", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ComputerRepairs", "Price", c => c.Int(nullable: false));
        }
    }
}
