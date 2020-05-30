namespace Veterinaria.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatePetImage : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Pets", "Image", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Pets", "Image", c => c.Binary());
        }
    }
}
