namespace MappingWithWindowsForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Map",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MapName = c.String(maxLength: 50),
                        ButtonName = c.String(maxLength: 50),
                        Guid = c.Guid(nullable: false),
                        X = c.Int(),
                        Y = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Map");
        }
    }
}
