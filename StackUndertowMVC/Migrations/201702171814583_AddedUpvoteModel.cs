namespace StackUndertowMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedUpvoteModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Upvotes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        VoterId = c.String(maxLength: 128),
                        AnswerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Answers", t => t.AnswerId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.VoterId)
                .Index(t => t.VoterId)
                .Index(t => t.AnswerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Upvotes", "VoterId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Upvotes", "AnswerId", "dbo.Answers");
            DropIndex("dbo.Upvotes", new[] { "AnswerId" });
            DropIndex("dbo.Upvotes", new[] { "VoterId" });
            DropTable("dbo.Upvotes");
        }
    }
}
