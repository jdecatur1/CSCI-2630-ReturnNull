namespace EDeviceClaims.Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedClaimEntity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "App.claims",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        PolicyId = c.Guid(nullable: false),
                        WhenCreated = c.DateTime(nullable: false),
                        WhenLastModified = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("app.policies", t => t.PolicyId, cascadeDelete: true)
                .Index(t => t.PolicyId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("App.claims", "PolicyId", "app.policies");
            DropIndex("App.claims", new[] { "PolicyId" });
            DropTable("App.claims");
        }
    }
}
