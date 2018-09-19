namespace BasicForecaster.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ItemSetupModelMigration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Item Setup", "Forecast Period Aggregation Preference", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Item Setup", "Forecast Period Aggregation Preference", c => c.Int(nullable: false));
        }
    }
}
