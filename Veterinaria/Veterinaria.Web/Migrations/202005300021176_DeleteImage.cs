namespace Veterinaria.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteImage : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Pets", "Image");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pets", "Image", c => c.String());
        }
    }
}
