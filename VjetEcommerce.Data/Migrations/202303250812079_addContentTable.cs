namespace VjetEcommerce.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addContentTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Slides", "DisplayOrder", c => c.Int());
            AddColumn("dbo.Slides", "Content", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Slides", "Content");
            DropColumn("dbo.Slides", "DisplayOrder");
        }
    }
}
