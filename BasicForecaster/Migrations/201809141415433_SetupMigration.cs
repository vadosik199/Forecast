namespace BasicForecaster.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetupMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Assembly Orders Production Orders",
                c => new
                    {
                        ProductionOrderNo = c.String(name: "Production Order No", nullable: false, maxLength: 30),
                        ItemCode = c.String(name: "Item Code", maxLength: 30),
                        ItemDescription = c.String(name: "Item Description", maxLength: 100),
                        QuantitytoMake = c.Double(name: "Quantity to Make"),
                        UnitOfMeasure = c.String(name: "Unit Of Measure", maxLength: 30),
                        ExpectedcompletionDate = c.DateTime(name: "Expected completion  Date"),
                        VariantCode = c.String(name: "Variant Code", maxLength: 30),
                        LocationCode = c.String(name: "Location Code", maxLength: 30),
                        OrderDate = c.DateTime(name: "Order Date"),
                    })
                .PrimaryKey(t => t.ProductionOrderNo);
            
            CreateTable(
                "dbo.BOM Setup",
                c => new
                    {
                        BOMNo = c.String(name: "BOM No", nullable: false, maxLength: 30),
                        LineNo = c.Int(name: "Line No"),
                        BOMItemNo = c.String(name: "BOM Item No", maxLength: 50),
                        BOMVariantCode = c.String(name: "BOM Variant Code"),
                        Description = c.String(maxLength: 100),
                        BOMUnitofMeasureCode = c.String(name: "BOM Unit of Measure Code", maxLength: 10),
                        BOMQuantity = c.Double(name: "BOM Quantity"),
                        CompItemNo = c.String(name: "Comp Item No"),
                        Quantityper = c.Double(name: "Quantity per"),
                        QuantityPerbase = c.Double(name: "Quantity Per base"),
                        CompvariantCode = c.String(name: "Comp variant Code", maxLength: 30),
                    })
                .PrimaryKey(t => t.BOMNo);
            
            CreateTable(
                "dbo.Customer Buying Calendar",
                c => new
                    {
                        CalendarCode = c.String(name: "Calendar Code", nullable: false, maxLength: 30),
                        ItemCode = c.String(name: "Item Code", maxLength: 30),
                        ItemDescription = c.String(name: "Item Description", maxLength: 100),
                        Quantitytobuy = c.Double(name: "Quantity to buy"),
                        UnitOfMeasure = c.String(name: "Unit Of Measure", maxLength: 30),
                        CustomerLocationcode = c.String(name: "Customer Location code", maxLength: 30),
                        VariantCode = c.String(name: "Variant Code", maxLength: 30),
                        LocationCode = c.String(name: "Location Code", maxLength: 30),
                        OrderDate = c.DateTime(name: "Order Date"),
                    })
                .PrimaryKey(t => t.CalendarCode);
            
            CreateTable(
                "dbo.Customer Item Price",
                c => new
                    {
                        ItemNo = c.String(name: "Item No", nullable: false, maxLength: 30),
                        CustomerCode = c.String(name: "Customer Code", nullable: false, maxLength: 30),
                        StartDate = c.DateTime(name: "Start Date", nullable: false),
                        Description = c.String(maxLength: 100),
                        CustomerDescription = c.String(name: "Customer Description", maxLength: 100),
                        UnitPrice = c.Int(name: "Unit Price"),
                        MinimumQty = c.Double(name: "Minimum Qty"),
                        EndDate = c.DateTime(name: "End Date"),
                        UnitofMeasure = c.String(name: "Unit of Measure"),
                        VariantCode = c.String(name: "Variant Code", maxLength: 30),
                    })
                .PrimaryKey(t => new { t.ItemNo, t.CustomerCode, t.StartDate });
            
            CreateTable(
                "dbo.Customer Location",
                c => new
                    {
                        CustomerLocationCode = c.String(name: "Customer Location Code", nullable: false, maxLength: 30),
                        Description = c.String(maxLength: 100),
                        Blocked = c.Boolean(),
                        POSDataExist = c.Double(name: "POS Data Exist"),
                        StoreNo = c.String(name: "Store No", maxLength: 30),
                    })
                .PrimaryKey(t => t.CustomerLocationCode);
            
            CreateTable(
                "dbo.Customer Setup",
                c => new
                    {
                        CustomerNo = c.String(name: "Customer No", nullable: false, maxLength: 30),
                        Description = c.String(maxLength: 100),
                        Blocked = c.Boolean(),
                        POSDataExist = c.Boolean(name: "POS Data Exist"),
                        CustomerLocationCode = c.String(name: "Customer Location Code", maxLength: 30),
                        CustomerbuyingCalendar = c.String(name: "Customer buying Calendar", maxLength: 30),
                        RetailerCode = c.String(name: "Retailer Code", maxLength: 30),
                    })
                .PrimaryKey(t => t.CustomerNo);
            
            /*CreateTable(
                "dbo.Exclude From History",
                c => new
                    {
                        ItemNo = c.String(name: "Item No", nullable: false, maxLength: 20, unicode: false),
                        Description = c.String(maxLength: 50, unicode: false),
                        LineNo = c.Int(name: "Line No"),
                        FromDate = c.DateTime(name: "From Date", storeType: "date"),
                        ToDate = c.DateTime(name: "To Date", storeType: "date"),
                    })
                .PrimaryKey(t => t.ItemNo);*/
            
            /*CreateTable(
                "dbo.Forecast Data",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ItemNo = c.String(name: "Item No", maxLength: 20, unicode: false),
                        EntryNo = c.Int(name: "Entry No"),
                        Description = c.String(maxLength: 50, unicode: false),
                        ActualSalesQty = c.Decimal(name: "Actual Sales Qty", precision: 18, scale: 0),
                        ForecastUOM = c.String(name: "Forecast UOM", maxLength: 10, unicode: false),
                        ForecastValue1 = c.Decimal(name: "Forecast Value 1", precision: 18, scale: 0),
                        ForecastValue2 = c.Decimal(name: "Forecast Value 2", precision: 18, scale: 0),
                        ForecastValue3 = c.Decimal(name: "Forecast Value 3", precision: 18, scale: 0),
                        ForecastValue4 = c.Decimal(name: "Forecast Value 4", precision: 18, scale: 0),
                        ForecastValue5 = c.Decimal(name: "Forecast Value 5", precision: 18, scale: 0),
                        MODError = c.Decimal(name: "MOD/Error", precision: 18, scale: 0),
                        BestValue = c.Decimal(name: "Best Value", precision: 18, scale: 0),
                        Location = c.String(maxLength: 10, unicode: false),
                        ForecastHorizon = c.String(name: "Forecast Horizon", maxLength: 100, unicode: false),
                        ForecastFromDate = c.DateTime(name: "Forecast From Date", storeType: "date"),
                        ForecastToDate = c.DateTime(name: "Forecast To Date", storeType: "date"),
                        SeasonalityExist = c.Boolean(name: "Seasonality Exist"),
                        ForecastPeriod = c.String(name: "Forecast Period", maxLength: 100, unicode: false),
                        ItemCategory = c.String(name: "Item Category", maxLength: 10, unicode: false),
                        BestMethod = c.String(name: "Best Method", maxLength: 10, unicode: false),
                        DateLastRun = c.DateTime(name: "Date Last Run", storeType: "date"),
                    })
                .PrimaryKey(t => t.Id);*/
            
            /*CreateTable(
                "dbo.Forecast Item Master",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ItemNo = c.String(name: "Item No", maxLength: 20, unicode: false),
                        ItemDescription = c.String(name: "Item Description", maxLength: 50, unicode: false),
                        BaseUnitofMeasure = c.String(name: "Base Unit of Measure", maxLength: 10, unicode: false),
                        PurchaseUnitofMeasure = c.String(name: "Purchase Unit of Measure", maxLength: 10, unicode: false),
                        SalesUnitofMeasure = c.String(name: "Sales Unit of Measure", maxLength: 10, unicode: false),
                        UsehistoryofItem = c.String(name: "Use history of Item", maxLength: 20, unicode: false),
                        Seasonalitem = c.Boolean(name: "Seasonal item"),
                        Safetystock = c.Int(name: "Safety stock"),
                        Customerbuyingcalendar = c.String(name: "Customer buying calendar", maxLength: 20, unicode: false),
                        Vendorbuyingcalendar = c.String(name: "Vendor buying calendar", maxLength: 20, unicode: false),
                        PeriodaggregationPreference = c.String(name: "Period aggregation Preference", maxLength: 30, unicode: false),
                        Periodstobeusedforhistory = c.String(name: "Periods to be used for history", maxLength: 100, unicode: false),
                        ForecastingMethod = c.String(name: "Forecasting Method", maxLength: 20, unicode: false),
                        UsePOSdata = c.Boolean(name: "Use POS data"),
                        ItemClassification = c.String(name: "Item Classification", maxLength: 100, unicode: false),
                        ForecastbyVariants = c.Boolean(name: "Forecast by Variants"),
                        IncludeSalesReturn = c.Boolean(name: "Include Sales Return"),
                        AlphaFactor = c.Decimal(name: "Alpha Factor", precision: 18, scale: 0),
                        BetaFactor = c.Decimal(name: "Beta Factor", precision: 18, scale: 0),
                        GammaFactor = c.Decimal(name: "Gamma Factor", precision: 18, scale: 0),
                        DeltaFactor = c.Decimal(name: "Delta Factor", precision: 18, scale: 0),
                        ItemCategory = c.String(name: "Item Category", maxLength: 20, unicode: false),
                        TrackingLimit = c.Decimal(name: "Tracking Limit", precision: 18, scale: 0),
                        FactorOptimization = c.Boolean(name: "Factor Optimization"),
                        ForecastHorizon = c.String(name: "Forecast Horizon", maxLength: 100, unicode: false),
                        MADTolerence = c.Decimal(name: "MAD Tolerence", precision: 18, scale: 0),
                        SeasonalCyclePeriod = c.String(name: "Seasonal Cycle Period", maxLength: 100, unicode: false),
                        Initialization = c.String(maxLength: 1, unicode: false),
                        ModelSelection = c.String(name: "Model Selection", maxLength: 10, unicode: false),
                        ForecastUnitofMeasure = c.String(name: "Forecast Unit of Measure", maxLength: 10, unicode: false),
                        ForecastbyLocation = c.Boolean(name: "Forecast by Location"),
                        SimpleMAPeriod = c.String(name: "Simple M.A Period", maxLength: 50, unicode: false),
                        CenteredMAPeriod = c.String(name: "Centered M.A Period", maxLength: 50, unicode: false),
                        Variantsexist = c.Boolean(name: "Variants exist"),
                        SeasonalPeriodLength = c.String(name: "Seasonal Period Length", maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id);*/
            
            /*CreateTable(
                "dbo.Forecast Methods",
                c => new
                    {
                        Code = c.String(nullable: false, maxLength: 20, unicode: false),
                        Description = c.String(maxLength: 50, unicode: false),
                        AlphaFactor = c.Decimal(name: "Alpha Factor", precision: 18, scale: 0),
                        BetaFactor = c.Decimal(name: "Beta Factor", precision: 18, scale: 0),
                        GammaFactor = c.Decimal(name: "Gamma Factor", precision: 18, scale: 0),
                        DeltaFactor = c.Decimal(name: "Delta Factor", precision: 18, scale: 0),
                        TrackingLimit = c.Decimal(name: "Tracking Limit", precision: 18, scale: 0),
                        FactorOptimizaton = c.Boolean(name: "Factor Optimizaton"),
                        ForecastHorizon = c.String(name: "Forecast Horizon", maxLength: 100, unicode: false),
                        MADTolerence = c.Decimal(name: "MAD Tolerence", precision: 18, scale: 0),
                        Ranking = c.Int(),
                        SimpleMAPeriod = c.String(name: "Simple M.A Period", maxLength: 50, unicode: false),
                        CenteredMAPeriod = c.String(name: "Centered M.A Period", maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Code);*/
            
            /*CreateTable(
                "dbo.Forecast Setup",
                c => new
                    {
                        PrimaryKey = c.String(name: "Primary Key", nullable: false, maxLength: 10, unicode: false),
                        DefaultForecastPeriod = c.String(name: "Default Forecast Period", maxLength: 100, unicode: false),
                        DefaultPeriodSelection = c.String(name: "Default Period Selection", maxLength: 50, unicode: false),
                        ForecastValue1 = c.String(name: "Forecast Value 1", maxLength: 10, unicode: false),
                        ForecastValue2 = c.String(name: "Forecast Value 2", maxLength: 10, unicode: false),
                        ForecastValue3 = c.String(name: "Forecast Value 3", maxLength: 10, unicode: false),
                        ForecastValue4 = c.String(name: "Forecast Value 4", maxLength: 10, unicode: false),
                        ForecastValue5 = c.String(name: "Forecast Value 5", maxLength: 10, unicode: false),
                        FiscalYearStartingDate = c.DateTime(name: "Fiscal Year Starting Date", storeType: "date"),
                        FiscalYearEndingDate = c.DateTime(name: "Fiscal Year Ending Date", storeType: "date"),
                        NoofPeriods = c.Int(name: "No of Periods"),
                        PeriodLength = c.String(name: "Period Length", maxLength: 100, unicode: false),
                        DefaultPeriodforActual = c.String(name: "Default Period for Actual", maxLength: 100, unicode: false),
                        Overlapperiod = c.String(name: "Overlap period", maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.PrimaryKey);*/
            
            CreateTable(
                "dbo.Item Setup",
                c => new
                    {
                        ItemNo = c.String(name: "Item No.", nullable: false, maxLength: 20),
                        ItemDescription = c.String(name: "Item Description", maxLength: 50),
                        BaseUnitofMeasure = c.String(name: "Base Unit of Measure", maxLength: 10),
                        PurchaseUnitofMeasure = c.String(name: "Purchase Unit of Measure", maxLength: 10),
                        SalesUnitofMeasure = c.String(name: "Sales Unit of Measure", maxLength: 10),
                        UsehistoryofItem = c.String(name: "Use history of Item", maxLength: 20),
                        Seasonalitem = c.Boolean(name: "Seasonal item"),
                        Safetystock = c.Int(name: "Safety stock"),
                        Customerbuyingcalendar = c.String(name: "Customer buying calendar", maxLength: 20),
                        Vendorbuyingcalendar = c.String(name: "Vendor buying calendar", maxLength: 20),
                        LotaggregationPreference = c.Int(name: "Lot aggregation Preference"),
                        Periodstobeusedforhistory = c.String(name: "Periods to be used for history"),
                        ForecastingMethod = c.String(name: "Forecasting Method", maxLength: 20),
                        UsePOSdata = c.Boolean(name: "Use POS data"),
                        ItemClassification = c.Int(name: "Item Classification"),
                        Variantsexist = c.Boolean(name: "Variants exist"),
                        ForecastbyVariants = c.Boolean(name: "Forecast by Variants"),
                        IncludeSalesReturn = c.Boolean(name: "Include Sales Return"),
                        AlphaFactor = c.Double(name: "Alpha Factor"),
                        BetaFactor = c.Double(name: "Beta Factor"),
                        GammaFactor = c.Double(name: "Gamma Factor"),
                        DeltaFactor = c.Double(name: "Delta Factor"),
                        P = c.Double(),
                        D = c.Double(),
                        Q = c.Double(),
                        ItemCategory = c.String(name: "Item Category", maxLength: 20),
                        TrackingLimit = c.Double(name: "Tracking Limit"),
                        FactorOptimization = c.Boolean(name: "Factor Optimization"),
                        NoofPeriodtoForecast = c.Double(name: "No of Period to Forecast"),
                        ForecastPeriodAggregationPreference = c.Int(name: "Forecast Period Aggregation Preference", nullable: false),
                        MADTolerance = c.Double(name: "MAD Tolerance"),
                        SeasonalCyclePeriod = c.String(name: "Seasonal Cycle Period"),
                        Initialization = c.String(maxLength: 1),
                        ModelSelection = c.String(name: "Model Selection", maxLength: 10),
                        OptimizationLevel = c.String(name: "Optimization Level", maxLength: 10),
                        ForecastUnitofMeasure = c.String(name: "Forecast Unit of Measure", maxLength: 10),
                        ForecastbyLocation = c.Boolean(name: "Forecast by Location"),
                        ForecastByCustomer = c.Boolean(name: "Forecast By Customer"),
                        SimpleMAPeriod = c.Int(name: "Simple M.A Period"),
                        CenteredMAPeriod = c.Int(name: "Centered M.A Period"),
                        SeasonalPeriodLength = c.String(name: "Seasonal Period Length"),
                        SafetyStockQty = c.Double(name: "Safety Stock Qty"),
                        SafetyLeadTimeUOM = c.Int(name: "Safety Lead Time UOM"),
                        SafetyLeadTime = c.Int(name: "Safety Lead Time"),
                        ReorderPoint = c.Double(name: "Reorder Point"),
                        ReorderQuantity = c.Double(name: "Reorder Quantity"),
                        MinimumInventory = c.Double(name: "Minimum Inventory"),
                        MaximumInventory = c.Double(name: "Maximum Inventory"),
                        ForwardBackwardConsumptionUOM = c.Int(name: "Forward/Backward Consumption UOM"),
                        ForwardConsumption = c.Double(name: "Forward Consumption"),
                        BackwardConsumption = c.Double(name: "Backward  Consumption"),
                        BOMNO = c.String(name: "BOM NO", maxLength: 30),
                        ForecastUnitofMeasure2 = c.String(name: "Forecast Unit of Measure2", maxLength: 20),
                        LeadTimeUOM = c.Int(name: "Lead Time UOM"),
                        LeadTime = c.Double(name: "Lead Time"),
                        OverlapPeriod = c.Int(name: "Overlap Period"),
                        UPCCode = c.String(name: "UPC Code", maxLength: 50),
                        CustomerItemcode = c.String(name: "Customer Item code", maxLength: 30),
                        VendorItemcode = c.String(name: "Vendor Item code", maxLength: 30),
                        NoofVariants = c.Int(name: "No of Variants"),
                    })
                .PrimaryKey(t => t.ItemNo);
            
            CreateTable(
                "dbo.Location Setup",
                c => new
                    {
                        LocationCode = c.String(name: "Location Code", nullable: false, maxLength: 30),
                        Description = c.String(maxLength: 100),
                        Blocked = c.Boolean(),
                        Warehouse = c.Boolean(),
                        Address1 = c.String(),
                        Address2 = c.String(),
                        City = c.String(),
                        Zipcode = c.String(name: "Zip code"),
                        State = c.String(),
                        Country = c.String(),
                    })
                .PrimaryKey(t => t.LocationCode);
            
            /*CreateTable(
                "dbo.Model Selection",
                c => new
                    {
                        Code = c.String(nullable: false, maxLength: 10, unicode: false),
                        Description = c.String(maxLength: 50, unicode: false),
                        ExTrend = c.Boolean(name: "Ex Trend"),
                        ExSeasonal = c.Boolean(name: "Ex Seasonal"),
                        ExTrendAndSeasonal = c.Boolean(name: "Ex Trend And Seasonal"),
                    })
                .PrimaryKey(t => t.Code);*/
            
            /*CreateTable(
                "dbo.Optimization Level",
                c => new
                    {
                        Code = c.String(nullable: false, maxLength: 10, unicode: false),
                        Description = c.String(maxLength: 50, unicode: false),
                        FromMAD = c.Int(name: "From MAD"),
                        ToMAD = c.Int(name: "To MAD"),
                    })
                .PrimaryKey(t => t.Code);*/
            
            CreateTable(
                "dbo.Planning Setup",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ReorderPoint = c.Double(name: "Reorder Point"),
                        ReorderQuantity = c.Double(name: "Reorder Quantity"),
                        LotAccumulationPeriod = c.Int(name: "Lot Accumulation Period"),
                        ForecastPeriodAggregationPreference = c.Int(name: "Forecast Period Aggregation Preference"),
                        ForwardBackwardConsumptionUOM = c.Int(name: "Forward Backward Consumption UOM"),
                        ForwardConsumption = c.Double(name: "Forward Consumption"),
                        BackwardConsumption = c.Double(name: "Backward  Consumption"),
                        SafetyStockQty = c.Double(name: "Safety Stock Qty"),
                        SafetyStockLeadtimeUOM = c.Int(name: "Safety Stock Lead time  UOM"),
                        SafetyStockLeadtime = c.Double(name: "Safety Stock Lead time"),
                        NoofPeriodtoForecast = c.Double(name: "No of Period to Forecast"),
                        PeriodstobeusedforhistoryUOM = c.Int(name: "Periods to be used for history UOM"),
                        Periodstobeusedforhistory = c.Int(name: "Periods to be used for history"),
                        DeportRequirementPlanning = c.Boolean(name: "Deport Requirement Planning"),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.POS History",
                c => new
                    {
                        EntryNo = c.Double(name: "Entry No", nullable: false),
                        StoreNo = c.String(name: "Store No", maxLength: 30),
                        StoreName = c.String(name: "Store Name", maxLength: 100),
                        Retailor = c.String(maxLength: 100),
                        Address1 = c.String(maxLength: 50),
                        Address2 = c.String(maxLength: 50),
                        City = c.String(maxLength: 50),
                        State = c.String(maxLength: 50),
                        Zip = c.String(maxLength: 50),
                        UPCCode = c.String(maxLength: 50),
                        CustomerItemNo = c.String(name: "Customer Item No", maxLength: 30),
                        Itemcode = c.String(name: "Item code", maxLength: 30),
                        ItemDescription = c.String(name: "Item Description", maxLength: 100),
                        Brand = c.String(maxLength: 50),
                        SalesPrice = c.Int(name: "Sales Price"),
                        QuantitySold = c.Double(name: "Quantity Sold"),
                        UnitOfMeasure = c.String(name: "Unit Of Measure", maxLength: 30),
                        SaleDate = c.DateTime(name: "Sale Date"),
                        CustomerID = c.String(name: "Customer ID", maxLength: 30),
                        VariantCode = c.String(name: "Variant Code", maxLength: 30),
                    })
                .PrimaryKey(t => t.EntryNo);
            
            CreateTable(
                "dbo.Purchase Orders",
                c => new
                    {
                        PurchaseOrderNo = c.String(name: "Purchase Order No", nullable: false, maxLength: 30),
                        VendorCode = c.String(name: "Vendor Code", maxLength: 30),
                        Description = c.String(maxLength: 100),
                        ItemCode = c.String(name: "Item Code", maxLength: 30),
                        ItemDescription = c.String(name: "Item Description", maxLength: 100),
                        PurchasePrice = c.Int(name: "Purchase Price"),
                        Quantity = c.Double(),
                        UnitOfMeasure = c.String(name: "Unit Of Measure", maxLength: 30),
                        ExpectedReceiptDate = c.DateTime(name: "Expected Receipt  Date"),
                        LocationCode = c.String(name: "Location Code", maxLength: 30),
                        VariantCode = c.String(name: "Variant Code", maxLength: 30),
                        VendorLocationCode = c.String(name: "Vendor Location Code", maxLength: 30),
                        OrderDate = c.DateTime(name: "Order Date"),
                    })
                .PrimaryKey(t => t.PurchaseOrderNo);
            
            /*CreateTable(
                "dbo.Sales History",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EntryNo = c.Int(name: "Entry No", nullable: false),
                        ItemNo = c.String(name: "Item No", nullable: false, maxLength: 20, unicode: false),
                        ItemDescription = c.String(name: "Item Description", maxLength: 50, unicode: false),
                        ItemDescription2 = c.String(name: "Item Description2", maxLength: 50, unicode: false),
                        ItemVariant = c.String(name: "Item Variant", maxLength: 20, unicode: false),
                        BaseUnitofMeasure = c.String(name: "Base Unit of Measure", maxLength: 10, unicode: false),
                        ForecastUnitofMeasure = c.String(name: "Forecast Unit of Measure", maxLength: 10, unicode: false),
                        Type = c.String(maxLength: 16, unicode: false),
                        SalesQuantity = c.Decimal(name: "Sales Quantity", precision: 18, scale: 0),
                        ReturnQuantity = c.Decimal(name: "Return Quantity", precision: 18, scale: 0),
                        ShipmentDate = c.DateTime(name: "Shipment Date", storeType: "date"),
                        InvoiceDate = c.DateTime(name: "Invoice Date", storeType: "date"),
                        Location = c.String(maxLength: 10, unicode: false),
                        SalesQuantityFUOM = c.Decimal(name: "Sales Quantity - FUOM", precision: 18, scale: 0),
                        SalesPrice = c.Decimal(name: "Sales Price", precision: 18, scale: 0),
                        SalesDiscount = c.Decimal(name: "Sales Discount", precision: 18, scale: 0),
                        ItemLedEntryNo = c.Int(name: "Item Led. Entry No"),
                        ItemCategory = c.String(name: "Item Category", maxLength: 20, unicode: false),
                    })
                .PrimaryKey(t => t.Id);*/
            
            /*CreateTable(
                "dbo.Sales Price Change",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EntryNo = c.Int(name: "Entry No"),
                        ItemNo = c.String(name: "Item No", maxLength: 20, unicode: false),
                        ItemDescription = c.String(name: "Item Description", maxLength: 50, unicode: false),
                        ItemDescription2 = c.String(name: "Item Description2", maxLength: 50, unicode: false),
                        ItemVariant = c.String(name: "Item Variant", maxLength: 20, unicode: false),
                        BaseUnitofMeasure = c.String(name: "Base Unit of Measure", maxLength: 10, unicode: false),
                        ForecastUnitofMeasure = c.String(name: "Forecast Unit of Measure", maxLength: 10, unicode: false),
                        Type = c.String(maxLength: 50, unicode: false),
                        SalesQuantity = c.Decimal(name: "Sales Quantity", precision: 18, scale: 0),
                        ReturnQuantity = c.Decimal(name: "Return Quantity", precision: 18, scale: 0),
                        ShipmentDate = c.DateTime(name: "Shipment Date", storeType: "date"),
                        InvoiceDate = c.DateTime(name: "Invoice Date", storeType: "date"),
                        Location = c.String(maxLength: 10, unicode: false),
                        SalesQuantityFUOM = c.Decimal(name: "Sales Quantity - FUOM", precision: 18, scale: 0),
                        SalesPrice = c.Decimal(name: "Sales Price", precision: 18, scale: 0),
                        SalesDiscount = c.Decimal(name: "Sales Discount", precision: 18, scale: 0),
                    })
                .PrimaryKey(t => t.Id);*/
            
            CreateTable(
                "dbo.Sales Orders",
                c => new
                    {
                        SalesOrderNo = c.String(name: "Sales Order No", nullable: false, maxLength: 30),
                        CustomerCode = c.String(name: "Customer Code", maxLength: 30),
                        Description = c.String(maxLength: 100),
                        ItemCode = c.String(name: "Item Code", maxLength: 30),
                        ItemDescription = c.String(name: "Item Description", maxLength: 30),
                        SalesPrice = c.Int(name: "Sales Price"),
                        Quantity = c.Double(),
                        UnitOfMeasure = c.String(name: "Unit Of Measure", maxLength: 30),
                        ShipmentDate = c.DateTime(name: "Shipment Date "),
                        VariantCode = c.String(name: "Variant Code", maxLength: 30),
                        LocationCode = c.String(name: "Location Code", maxLength: 30),
                        CustomerLocationCode = c.String(name: "Customer Location Code", maxLength: 30),
                        Orderdate = c.DateTime(name: "Order date"),
                    })
                .PrimaryKey(t => t.SalesOrderNo);
            
            CreateTable(
                "dbo.Sales Price Change History",
                c => new
                    {
                        EntryNo = c.String(name: "Entry No.", nullable: false, maxLength: 128),
                        ItemNo = c.String(name: "Item No", maxLength: 30),
                        Description = c.String(maxLength: 100),
                        CustomerCode = c.String(name: "Customer Code", maxLength: 30),
                        CustomerDescription = c.String(name: "Customer Description", maxLength: 100),
                        SalesPrice = c.Int(name: "Sales Price"),
                        UnitOfMeasure = c.String(name: "Unit Of Measure", maxLength: 30),
                        ShipmentDate = c.DateTime(name: "Shipment Date"),
                        VariantCode = c.String(name: "Variant Code", maxLength: 30),
                    })
                .PrimaryKey(t => t.EntryNo);
            
            CreateTable(
                "dbo.Unit of Measure",
                c => new
                    {
                        UnitofMeasure = c.String(name: "Unit of Measure", nullable: false, maxLength: 30),
                        Description = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.UnitofMeasure);
            
            CreateTable(
                "dbo.Variant Setup",
                c => new
                    {
                        ItemCode = c.String(name: "Item Code", nullable: false, maxLength: 30),
                        VariantCode = c.String(name: "Variant Code", nullable: false, maxLength: 30),
                        Description = c.String(maxLength: 100),
                        ItemDescription = c.String(name: "Item Description"),
                        UnitofMeasureCode = c.String(name: "Unit of Measure Code", maxLength: 20),
                        Locationcode = c.String(name: "Location code", maxLength: 30),
                        CustomerVariantCode = c.String(name: "Customer Variant Code", maxLength: 30),
                        VendorVariantCode = c.String(name: "Vendor Variant Code", maxLength: 30),
                    })
                .PrimaryKey(t => new { t.ItemCode, t.VariantCode });
            
            CreateTable(
                "dbo.Vendor Location",
                c => new
                    {
                        VendorLocationCode = c.String(name: "Vendor Location Code", nullable: false, maxLength: 30),
                        Description = c.String(maxLength: 100),
                        Blocked = c.Boolean(),
                    })
                .PrimaryKey(t => t.VendorLocationCode);
            
            CreateTable(
                "dbo.Vendor Setup",
                c => new
                    {
                        VendorNo = c.String(name: "Vendor No", nullable: false, maxLength: 30),
                        Description = c.String(maxLength: 100),
                        Blocked = c.Boolean(),
                        ItemCode = c.String(name: "Item Code", maxLength: 30),
                        ItemDescription = c.String(name: "Item Description", maxLength: 100),
                        LeadtimeUOM = c.Int(name: "Lead time UOM"),
                        Leadtime = c.Decimal(name: "Lead time", precision: 18, scale: 2),
                        VendorLocationCode = c.String(name: "Vendor Location Code", maxLength: 30),
                        VariantCode = c.String(name: "Variant Code", maxLength: 30),
                    })
                .PrimaryKey(t => t.VendorNo);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Vendor Setup");
            DropTable("dbo.Vendor Location");
            DropTable("dbo.Variant Setup");
            DropTable("dbo.Unit of Measure");
            DropTable("dbo.Sales Price Change History");
            DropTable("dbo.Sales Orders");
            DropTable("dbo.Sales Price Change");
            DropTable("dbo.Sales History");
            DropTable("dbo.Purchase Orders");
            DropTable("dbo.POS History");
            DropTable("dbo.Planning Setup");
            DropTable("dbo.Optimization Level");
            DropTable("dbo.Model Selection");
            DropTable("dbo.Location Setup");
            DropTable("dbo.Item Setup");
            DropTable("dbo.Forecast Setup");
            DropTable("dbo.Forecast Methods");
            DropTable("dbo.Forecast Item Master");
            DropTable("dbo.Forecast Data");
            DropTable("dbo.Exclude From History");
            DropTable("dbo.Customer Setup");
            DropTable("dbo.Customer Location");
            DropTable("dbo.Customer Item Price");
            DropTable("dbo.Customer Buying Calendar");
            DropTable("dbo.BOM Setup");
            DropTable("dbo.Assembly Orders Production Orders");
        }
    }
}
