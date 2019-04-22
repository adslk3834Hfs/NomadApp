namespace NomadApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Mail = c.String(),
                        Phone = c.String(),
                        Login = c.String(),
                        Age = c.Int(nullable: false),
                        Password = c.String(),
                        Publisher_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Publishers", t => t.Publisher_Id)
                .Index(t => t.Publisher_Id);
            
            CreateTable(
                "dbo.Journals",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        JournalNumber = c.String(),
                        IsReady = c.Boolean(nullable: false),
                        Publisher_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Publishers", t => t.Publisher_Id)
                .Index(t => t.Publisher_Id);
            
            CreateTable(
                "dbo.Publishers",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Journals", "Publisher_Id", "dbo.Publishers");
            DropForeignKey("dbo.Clients", "Publisher_Id", "dbo.Publishers");
            DropIndex("dbo.Journals", new[] { "Publisher_Id" });
            DropIndex("dbo.Clients", new[] { "Publisher_Id" });
            DropTable("dbo.Publishers");
            DropTable("dbo.Journals");
            DropTable("dbo.Clients");
        }
    }
}
