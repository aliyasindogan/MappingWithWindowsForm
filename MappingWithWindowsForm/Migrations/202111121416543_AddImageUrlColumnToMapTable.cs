namespace MappingWithWindowsForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddImageUrlColumnToMapTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Map", "ImageUrl", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Map", "ImageUrl");
        }
    }
}
