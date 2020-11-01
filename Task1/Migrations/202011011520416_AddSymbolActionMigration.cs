namespace Task1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSymbolActionMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SymbolActions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PasswordActionId = c.Int(nullable: false),
                        KeyValue = c.Int(nullable: false),
                        KeyDownTime = c.Double(nullable: false),
                        KeyUpTime = c.Double(nullable: false),
                        OverlayEndingTime = c.Double(nullable: false),
                        IsShiftPressed = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PasswordActions", t => t.PasswordActionId, cascadeDelete: true)
                .Index(t => t.PasswordActionId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SymbolActions", "PasswordActionId", "dbo.PasswordActions");
            DropIndex("dbo.SymbolActions", new[] { "PasswordActionId" });
            DropTable("dbo.SymbolActions");
        }
    }
}
