namespace MappingWithWindowsForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDisplayOrderColumnToMapTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Map", "DisplayOrder", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Map", "DisplayOrder");
        }
    }
}
