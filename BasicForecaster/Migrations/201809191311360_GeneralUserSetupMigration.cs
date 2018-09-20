namespace BasicForecaster.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GeneralUserSetupMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.General Setup",
                c => new
                    {
                        CompanyNo = c.Int(name: "Company No.", nullable: false, identity: true),
                        CompanyName = c.String(name: "Company Name"),
                    })
                .PrimaryKey(t => t.CompanyNo);
            
            CreateTable(
                "dbo.User Setup",
                c => new
                    {
                        UserID = c.String(name: "User ID", nullable: false, maxLength: 128),
                        FirstName = c.String(name: "First Name"),
                        MiddleName = c.String(name: "Middle Name"),
                        LastName = c.String(name: "Last Name"),
                        Password = c.String(),
                        Permission = c.String(),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.User Setup");
            DropTable("dbo.General Setup");
        }
    }
}
