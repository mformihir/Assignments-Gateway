namespace DataAnnotationsExample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "CreditCard", c => c.String());
            AlterColumn("dbo.People", "Name", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.People", "Username", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.People", "Email", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.People", "Email", c => c.String());
            AlterColumn("dbo.People", "Username", c => c.String());
            AlterColumn("dbo.People", "Name", c => c.String(maxLength: 30));
            DropColumn("dbo.People", "CreditCard");
        }
    }
}
