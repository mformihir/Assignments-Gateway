namespace DataAnnotationsExample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Final : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "Continent", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "Continent");
        }
    }
}
