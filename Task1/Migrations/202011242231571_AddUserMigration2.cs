namespace Task1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserMigration2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Login = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.PasswordActions", "UserId");
            AddForeignKey("dbo.PasswordActions", "UserId", "dbo.Users", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PasswordActions", "UserId", "dbo.Users");
            DropIndex("dbo.PasswordActions", new[] { "UserId" });
            DropTable("dbo.Users");
        }
    }
}
