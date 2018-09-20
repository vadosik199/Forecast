namespace BasicForecaster.Models {
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using BasicForecaster.Models.Setup;
    using System.Windows;
    using BasicForecaster.Interfaces;

    public partial class dbContext : DbContext {
        private static dbContext instance;

        public dbContext()
            : base("name=dbContext") {
        }

        public static dbContext GetInstance()
        {
            if (instance == null)
            {
                instance = new dbContext();
            }
            return instance;
        }

        public virtual DbSet<Exclude_From_History> Exclude_From_Histories { get; set; }
        public virtual DbSet<Forecast_datum> Forecast_Data { get; set; }
        public virtual DbSet<Forecast_Item_Master> Forecast_Item_Masters { get; set; }
        public virtual DbSet<Forecast_Method> Forecast_Methods { get; set; }
        public virtual DbSet<Forecast_Setup> Forecast_Setups { get; set; }
        public virtual DbSet<Model_Selection> Model_Selections { get; set; }
        public virtual DbSet<Optimization_Level> Optimization_Levels { get; set; }
        public virtual DbSet<Sales_History> Sales_Histories { get; set; }
        public virtual DbSet<Sales_Price_Change> Sales_Price_changes { get; set; }
        public virtual DbSet<AssemblyOrdersProductionOrders> AssemblyOrdersProductionOrders { get; set; }
        public virtual DbSet<BOMSetup> BOMSetup { get; set; }
        public virtual DbSet<CustomerBuyingCalendar> CustomerBuyingCalendar { get; set; }
        public virtual DbSet<CustomerItemPrice> CustomerItemPrice { get; set; }
        public virtual DbSet<CustomerLocation> CustomerLocation { get; set; }
        public virtual DbSet<CustomerSetup> CustomerSetup { get; set; }
        public virtual DbSet<ItemSetup> ItemSetup { get; set; }
        public virtual DbSet<LocationSetup> LocationSetup { get; set; }
        public virtual DbSet<PlanningSetup> PlanningSetup { get; set; }
        public virtual DbSet<POSHistory> POSHistory { get; set; }
        public virtual DbSet<PurchaseOrders> PurchaseOrders { get; set; }
        public virtual DbSet<SalesOrders> SalesOrders { get; set; }
        public virtual DbSet<SalesPriceChangeHistory> SalesPriceChangeHistory { get; set; }
        public virtual DbSet<UnitOfMeasure> UnitOfMeasure { get; set; }
        public virtual DbSet<VariantSetup> VariantSetup { get; set; }
        public virtual DbSet<VendorLocation> VendorLocation { get; set; }
        public virtual DbSet<VendorSetup> VendorSetup { get; set; }
        public virtual DbSet<UserSetup> UserSetup { get; set; }
        public virtual DbSet<GeneralSetup> GeneralSetup { get; set; }
        public virtual DbSet<ForecastSetup> ForecastSetup { get; set; }

        public void SaveData(IErrorHandler handler)
        {
            try
            {
                SaveChanges();
            }
            catch (Exception e)
            {
                handler.Handle(e);
            }
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Entity<Exclude_From_History>()
                .Property(e => e.Item_No)
                .IsUnicode(false);

            modelBuilder.Entity<Exclude_From_History>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Forecast_datum>()
                .Property(e => e.Item_No)
                .IsUnicode(false);

            modelBuilder.Entity<Forecast_datum>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Forecast_datum>()
                .Property(e => e.Actual_Sales_Qty)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Forecast_datum>()
                .Property(e => e.Forecast_UOM)
                .IsUnicode(false);

            modelBuilder.Entity<Forecast_datum>()
                .Property(e => e.Forecast_Value_1)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Forecast_datum>()
                .Property(e => e.Forecast_Value_2)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Forecast_datum>()
                .Property(e => e.Forecast_Value_3)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Forecast_datum>()
                .Property(e => e.Forecast_Value_4)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Forecast_datum>()
                .Property(e => e.Forecast_Value_5)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Forecast_datum>()
                .Property(e => e.MOD_Error)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Forecast_datum>()
                .Property(e => e.Best_Value)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Forecast_datum>()
                .Property(e => e.Location)
                .IsUnicode(false);

            modelBuilder.Entity<Forecast_datum>()
                .Property(e => e.Forecast_Horizon)
                .IsUnicode(false);

            modelBuilder.Entity<Forecast_datum>()
                .Property(e => e.Forecast_Period)
                .IsUnicode(false);

            modelBuilder.Entity<Forecast_datum>()
                .Property(e => e.Item_Category)
                .IsUnicode(false);

            modelBuilder.Entity<Forecast_datum>()
                .Property(e => e.Best_Method)
                .IsUnicode(false);

            modelBuilder.Entity<Forecast_Item_Master>()
                .Property(e => e.Item_No)
                .IsUnicode(false);

            modelBuilder.Entity<Forecast_Item_Master>()
                .Property(e => e.Item_Description)
                .IsUnicode(false);

            modelBuilder.Entity<Forecast_Item_Master>()
                .Property(e => e.Base_Unit_of_Measure)
                .IsUnicode(false);

            modelBuilder.Entity<Forecast_Item_Master>()
                .Property(e => e.Purchase_Unit_of_Measure)
                .IsUnicode(false);

            modelBuilder.Entity<Forecast_Item_Master>()
                .Property(e => e.Sales_Unit_of_Measure)
                .IsUnicode(false);

            modelBuilder.Entity<Forecast_Item_Master>()
                .Property(e => e.Use_history_of_Item)
                .IsUnicode(false);

            modelBuilder.Entity<Forecast_Item_Master>()
                .Property(e => e.Customer_buying_calendar)
                .IsUnicode(false);

            modelBuilder.Entity<Forecast_Item_Master>()
                .Property(e => e.Vendor_buying_calendar)
                .IsUnicode(false);

            modelBuilder.Entity<Forecast_Item_Master>()
                .Property(e => e.Period_aggregation_Preference)
                .IsUnicode(false);

            modelBuilder.Entity<Forecast_Item_Master>()
                .Property(e => e.Periods_to_be_used_for_history)
                .IsUnicode(false);

            modelBuilder.Entity<Forecast_Item_Master>()
                .Property(e => e.Forecasting_Method)
                .IsUnicode(false);

            modelBuilder.Entity<Forecast_Item_Master>()
                .Property(e => e.Item_Classification)
                .IsUnicode(false);

            modelBuilder.Entity<Forecast_Item_Master>()
                .Property(e => e.Alpha_Factor)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Forecast_Item_Master>()
                .Property(e => e.Beta_Factor)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Forecast_Item_Master>()
                .Property(e => e.Gamma_Factor)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Forecast_Item_Master>()
                .Property(e => e.Delta_Factor)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Forecast_Item_Master>()
                .Property(e => e.Item_Category)
                .IsUnicode(false);

            modelBuilder.Entity<Forecast_Item_Master>()
                .Property(e => e.Tracking_Limit)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Forecast_Item_Master>()
                .Property(e => e.Forecast_Horizon)
                .IsUnicode(false);

            modelBuilder.Entity<Forecast_Item_Master>()
                .Property(e => e.MAD_Tolerence)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Forecast_Item_Master>()
                .Property(e => e.Seasonal_Cycle_Period)
                .IsUnicode(false);

            modelBuilder.Entity<Forecast_Item_Master>()
                .Property(e => e.Initialization)
                .IsUnicode(false);

            modelBuilder.Entity<Forecast_Item_Master>()
                .Property(e => e.Model_Selection)
                .IsUnicode(false);

            modelBuilder.Entity<Forecast_Item_Master>()
                .Property(e => e.Forecast_Unit_of_Measure)
                .IsUnicode(false);

            modelBuilder.Entity<Forecast_Item_Master>()
                .Property(e => e.Simple_M_A_Period)
                .IsUnicode(false);

            modelBuilder.Entity<Forecast_Item_Master>()
                .Property(e => e.Centered_M_A_Period)
                .IsUnicode(false);

            modelBuilder.Entity<Forecast_Item_Master>()
                .Property(e => e.Seasonal_Period_Length)
                .IsUnicode(false);

            modelBuilder.Entity<Forecast_Method>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Forecast_Method>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Forecast_Method>()
                .Property(e => e.Alpha_Factor)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Forecast_Method>()
                .Property(e => e.Beta_Factor)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Forecast_Method>()
                .Property(e => e.Gamma_Factor)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Forecast_Method>()
                .Property(e => e.Delta_Factor)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Forecast_Method>()
                .Property(e => e.Tracking_Limit)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Forecast_Method>()
                .Property(e => e.Forecast_Horizon)
                .IsUnicode(false);

            modelBuilder.Entity<Forecast_Method>()
                .Property(e => e.MAD_Tolerence)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Forecast_Method>()
                .Property(e => e.Simple_M_A_Period)
                .IsUnicode(false);

            modelBuilder.Entity<Forecast_Method>()
                .Property(e => e.Centered_M_A_Period)
                .IsUnicode(false);

            modelBuilder.Entity<Forecast_Setup>()
                .Property(e => e.Primary_Key)
                .IsUnicode(false);

            modelBuilder.Entity<Forecast_Setup>()
                .Property(e => e.Default_Forecast_Period)
                .IsUnicode(false);

            modelBuilder.Entity<Forecast_Setup>()
                .Property(e => e.Default_Period_Selection)
                .IsUnicode(false);

            modelBuilder.Entity<Forecast_Setup>()
                .Property(e => e.Forecast_Value_1)
                .IsUnicode(false);

            modelBuilder.Entity<Forecast_Setup>()
                .Property(e => e.Forecast_Value_2)
                .IsUnicode(false);

            modelBuilder.Entity<Forecast_Setup>()
                .Property(e => e.Forecast_Value_3)
                .IsUnicode(false);

            modelBuilder.Entity<Forecast_Setup>()
                .Property(e => e.Forecast_Value_4)
                .IsUnicode(false);

            modelBuilder.Entity<Forecast_Setup>()
                .Property(e => e.Forecast_Value_5)
                .IsUnicode(false);

            modelBuilder.Entity<Forecast_Setup>()
                .Property(e => e.Period_Length)
                .IsUnicode(false);

            modelBuilder.Entity<Forecast_Setup>()
                .Property(e => e.Default_Period_for_Actual)
                .IsUnicode(false);

            modelBuilder.Entity<Forecast_Setup>()
                .Property(e => e.Overlap_period)
                .IsUnicode(false);

            modelBuilder.Entity<Model_Selection>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Model_Selection>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Optimization_Level>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Optimization_Level>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Sales_History>()
                .Property(e => e.Item_No)
                .IsUnicode(false);

            modelBuilder.Entity<Sales_History>()
                .Property(e => e.Item_Description)
                .IsUnicode(false);

            modelBuilder.Entity<Sales_History>()
                .Property(e => e.Item_Description2)
                .IsUnicode(false);

            modelBuilder.Entity<Sales_History>()
                .Property(e => e.Item_Variant)
                .IsUnicode(false);

            modelBuilder.Entity<Sales_History>()
                .Property(e => e.Base_Unit_of_Measure)
                .IsUnicode(false);

            modelBuilder.Entity<Sales_History>()
                .Property(e => e.Forecast_Unit_of_Measure)
                .IsUnicode(false);

            modelBuilder.Entity<Sales_History>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<Sales_History>()
                .Property(e => e.Sales_Quantity)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Sales_History>()
                .Property(e => e.Return_Quantity)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Sales_History>()
                .Property(e => e.Location)
                .IsUnicode(false);

            modelBuilder.Entity<Sales_History>()
                .Property(e => e.Sales_Quantity___FUOM)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Sales_History>()
                .Property(e => e.Sales_Price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Sales_History>()
                .Property(e => e.Sales_Discount)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Sales_History>()
                .Property(e => e.Item_Category)
                .IsUnicode(false);

            modelBuilder.Entity<Sales_Price_Change>()
                .Property(e => e.Item_No)
                .IsUnicode(false);

            modelBuilder.Entity<Sales_Price_Change>()
                .Property(e => e.Item_Description)
                .IsUnicode(false);

            modelBuilder.Entity<Sales_Price_Change>()
                .Property(e => e.Item_Description2)
                .IsUnicode(false);

            modelBuilder.Entity<Sales_Price_Change>()
                .Property(e => e.Item_Variant)
                .IsUnicode(false);

            modelBuilder.Entity<Sales_Price_Change>()
                .Property(e => e.Base_Unit_of_Measure)
                .IsUnicode(false);

            modelBuilder.Entity<Sales_Price_Change>()
                .Property(e => e.Forecast_Unit_of_Measure)
                .IsUnicode(false);

            modelBuilder.Entity<Sales_Price_Change>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<Sales_Price_Change>()
                .Property(e => e.Sales_Quantity)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Sales_Price_Change>()
                .Property(e => e.Return_Quantity)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Sales_Price_Change>()
                .Property(e => e.Location)
                .IsUnicode(false);

            modelBuilder.Entity<Sales_Price_Change>()
                .Property(e => e.Sales_Quantity___FUOM)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Sales_Price_Change>()
                .Property(e => e.Sales_Price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Sales_Price_Change>()
                .Property(e => e.Sales_Discount)
                .HasPrecision(18, 0);
        }
    }
}
