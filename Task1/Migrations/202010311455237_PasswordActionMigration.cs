namespace Task1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PasswordActionMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PasswordActions", "ValidPassword", c => c.String());
            AddColumn("dbo.PasswordActions", "StartTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PasswordActions", "StartTime");
            DropColumn("dbo.PasswordActions", "ValidPassword");
        }
    }
}
