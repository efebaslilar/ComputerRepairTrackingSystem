namespace ComputerRepairDataAccesL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class desing : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ComputerRepairs", "Enable", c => c.Boolean(nullable: false));
            AddColumn("dbo.ComputerRepairs", "IsDelete", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ComputerRepairs", "IsDelete");
            DropColumn("dbo.ComputerRepairs", "Enable");
        }
    }
}
