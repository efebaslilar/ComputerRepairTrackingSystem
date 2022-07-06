namespace ComputerRepairDataAccesL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class enable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ComputerRepairs", "Repaired", c => c.Boolean(nullable: false));
            DropColumn("dbo.ComputerRepairs", "Enable");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ComputerRepairs", "Enable", c => c.Boolean(nullable: false));
            DropColumn("dbo.ComputerRepairs", "Repaired");
        }
    }
}
