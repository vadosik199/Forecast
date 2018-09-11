namespace BasicForecaster.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sales Price Change")]
    public partial class Sales_Price_Change
    {
        public int Id { get; set; }

        [Column("Entry No")]
        public int? Entry_No { get; set; }

        [Column("Item No")]
        [StringLength(20)]
        public string Item_No { get; set; }

        [Column("Item Description")]
        [StringLength(50)]
        public string Item_Description { get; set; }

        [Column("Item Description2")]
        [StringLength(50)]
        public string Item_Description2 { get; set; }

        [Column("Item Variant")]
        [StringLength(20)]
        public string Item_Variant { get; set; }

        [Column("Base Unit of Measure")]
        [StringLength(10)]
        public string Base_Unit_of_Measure { get; set; }

        [Column("Forecast Unit of Measure")]
        [StringLength(10)]
        public string Forecast_Unit_of_Measure { get; set; }

        [StringLength(50)]
        public string Type { get; set; }

        [Column("Sales Quantity")]
        public decimal? Sales_Quantity { get; set; }

        [Column("Return Quantity")]
        public decimal? Return_Quantity { get; set; }

        [Column("Shipment Date", TypeName = "date")]
        public DateTime? Shipment_Date { get; set; }

        [Column("Invoice Date", TypeName = "date")]
        public DateTime? Invoice_Date { get; set; }

        [StringLength(10)]
        public string Location { get; set; }

        [Column("Sales Quantity - FUOM")]
        public decimal? Sales_Quantity___FUOM { get; set; }

        [Column("Sales Price")]
        public decimal? Sales_Price { get; set; }

        [Column("Sales Discount")]
        public decimal? Sales_Discount { get; set; }
    }
}
