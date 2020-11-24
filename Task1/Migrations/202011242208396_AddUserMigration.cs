namespace Task1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PasswordActions", "UserId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PasswordActions", "UserId");
        }
    }
}
