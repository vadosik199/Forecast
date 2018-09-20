namespace BasicForecaster.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ForecastMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Forecast Setup2",
                c => new
                    {
                        Code = c.String(nullable: false, maxLength: 20),
                        Description = c.String(maxLength: 50),
                        AlphaFactor = c.Double(name: "Alpha Factor"),
                        BetaFactor = c.Double(name: "Beta Factor"),
                        GammaFactor = c.Double(name: "Gamma Factor"),
                        DeltaFactor = c.Double(name: "Delta Factor"),
                        TrackingLimit = c.Double(name: "Tracking Limit"),
                        FactorOptimization = c.Boolean(name: "Factor Optimization"),
                        Ranking = c.Int(),
                        SimpleMAPeriodinMonths = c.Double(name: "Simple M.A Period in Months"),
                        CenteredMAPeriodinMonths = c.Double(name: "Centered M.A Period in Months"),
                        ForecastbyCustomer = c.Boolean(name: "Forecast by Customer"),
                        ForecastbyCustomerLocation = c.Boolean(name: "Forecast by Customer Location"),
                        ForecastbyLocation = c.Boolean(name: "Forecast by Location"),
                        ForecastbyVariant = c.Boolean(name: "Forecast by Variant"),
                        ForecastbyVendor = c.Boolean(name: "Forecast by Vendor"),
                        OverlapPeriod = c.Int(name: "Overlap Period"),
                    })
                .PrimaryKey(t => t.Code);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Forecast Setup2");
        }
    }
}
