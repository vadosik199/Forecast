namespace BasicForecaster
{
    partial class SalesOrdersCard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.salesOrderNoField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.customerCodeField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.descriptionField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.itemCodeField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.itemDescriptionField = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.salesPriceField = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.quantityField = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.unitOfMeasureField = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.shipmentDatePicker = new System.Windows.Forms.DateTimePicker();
            this.variantCodeField = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.locationCodeField = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.customerLocationCodeField = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.orderDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // salesOrderNoField
            // 
            this.salesOrderNoField.Location = new System.Drawing.Point(181, 12);
            this.salesOrderNoField.Name = "salesOrderNoField";
            this.salesOrderNoField.Size = new System.Drawing.Size(257, 20);
            this.salesOrderNoField.TabIndex = 21;
            this.salesOrderNoField.TextChanged += new System.EventHandler(this.salesOrderNoField_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Sales Order No";
            // 
            // customerCodeField
            // 
            this.customerCodeField.Location = new System.Drawing.Point(181, 38);
            this.customerCodeField.Name = "customerCodeField";
            this.customerCodeField.Size = new System.Drawing.Size(257, 20);
            this.customerCodeField.TabIndex = 23;
            this.customerCodeField.TextChanged += new System.EventHandler(this.customerCodeField_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Customer Code";
            // 
            // descriptionField
            // 
            this.descriptionField.Location = new System.Drawing.Point(181, 64);
            this.descriptionField.Name = "descriptionField";
            this.descriptionField.Size = new System.Drawing.Size(257, 20);
            this.descriptionField.TabIndex = 25;
            this.descriptionField.TextChanged += new System.EventHandler(this.descriptionField_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Description";
            // 
            // itemCodeField
            // 
            this.itemCodeField.Location = new System.Drawing.Point(181, 90);
            this.itemCodeField.Name = "itemCodeField";
            this.itemCodeField.Size = new System.Drawing.Size(257, 20);
            this.itemCodeField.TabIndex = 27;
            this.itemCodeField.TextChanged += new System.EventHandler(this.itemCodeField_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Item Code";
            // 
            // itemDescriptionField
            // 
            this.itemDescriptionField.Location = new System.Drawing.Point(181, 116);
            this.itemDescriptionField.Name = "itemDescriptionField";
            this.itemDescriptionField.Size = new System.Drawing.Size(257, 20);
            this.itemDescriptionField.TabIndex = 29;
            this.itemDescriptionField.TextChanged += new System.EventHandler(this.itemDescriptionField_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(12, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Item Description";
            // 
            // salesPriceField
            // 
            this.salesPriceField.Location = new System.Drawing.Point(181, 142);
            this.salesPriceField.Name = "salesPriceField";
            this.salesPriceField.Size = new System.Drawing.Size(257, 20);
            this.salesPriceField.TabIndex = 31;
            this.salesPriceField.TextChanged += new System.EventHandler(this.salesPriceField_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(12, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 30;
            this.label6.Text = "Sales Price";
            // 
            // quantityField
            // 
            this.quantityField.Location = new System.Drawing.Point(181, 168);
            this.quantityField.Name = "quantityField";
            this.quantityField.Size = new System.Drawing.Size(257, 20);
            this.quantityField.TabIndex = 33;
            this.quantityField.TextChanged += new System.EventHandler(this.quantityField_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(12, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 32;
            this.label7.Text = "Quantity";
            // 
            // unitOfMeasureField
            // 
            this.unitOfMeasureField.Location = new System.Drawing.Point(181, 194);
            this.unitOfMeasureField.Name = "unitOfMeasureField";
            this.unitOfMeasureField.Size = new System.Drawing.Size(257, 20);
            this.unitOfMeasureField.TabIndex = 35;
            this.unitOfMeasureField.TextChanged += new System.EventHandler(this.unitOfMeasureField_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(12, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 17);
            this.label8.TabIndex = 34;
            this.label8.Text = "Unit of Measure";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(12, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 17);
            this.label9.TabIndex = 36;
            this.label9.Text = "Shipment Date";
            // 
            // shipmentDatePicker
            // 
            this.shipmentDatePicker.Location = new System.Drawing.Point(181, 220);
            this.shipmentDatePicker.Name = "shipmentDatePicker";
            this.shipmentDatePicker.Size = new System.Drawing.Size(257, 20);
            this.shipmentDatePicker.TabIndex = 37;
            this.shipmentDatePicker.ValueChanged += new System.EventHandler(this.shipmentDatePicker_ValueChanged);
            // 
            // variantCodeField
            // 
            this.variantCodeField.Location = new System.Drawing.Point(181, 246);
            this.variantCodeField.Name = "variantCodeField";
            this.variantCodeField.Size = new System.Drawing.Size(257, 20);
            this.variantCodeField.TabIndex = 39;
            this.variantCodeField.TextChanged += new System.EventHandler(this.variantCodeField_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(12, 249);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 17);
            this.label10.TabIndex = 38;
            this.label10.Text = "Variant Code";
            // 
            // locationCodeField
            // 
            this.locationCodeField.Location = new System.Drawing.Point(181, 272);
            this.locationCodeField.Name = "locationCodeField";
            this.locationCodeField.Size = new System.Drawing.Size(257, 20);
            this.locationCodeField.TabIndex = 41;
            this.locationCodeField.TextChanged += new System.EventHandler(this.locationCodeField_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(12, 275);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 17);
            this.label11.TabIndex = 40;
            this.label11.Text = "Location Code";
            // 
            // customerLocationCodeField
            // 
            this.customerLocationCodeField.Location = new System.Drawing.Point(181, 298);
            this.customerLocationCodeField.Name = "customerLocationCodeField";
            this.customerLocationCodeField.Size = new System.Drawing.Size(257, 20);
            this.customerLocationCodeField.TabIndex = 43;
            this.customerLocationCodeField.TextChanged += new System.EventHandler(this.customerLocationCodeField_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.Location = new System.Drawing.Point(12, 301);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(163, 17);
            this.label12.TabIndex = 42;
            this.label12.Text = "Customer Location Code";
            // 
            // orderDatePicker
            // 
            this.orderDatePicker.Location = new System.Drawing.Point(181, 324);
            this.orderDatePicker.Name = "orderDatePicker";
            this.orderDatePicker.Size = new System.Drawing.Size(257, 20);
            this.orderDatePicker.TabIndex = 45;
            this.orderDatePicker.ValueChanged += new System.EventHandler(this.orderDatePicker_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.Location = new System.Drawing.Point(12, 327);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 17);
            this.label13.TabIndex = 44;
            this.label13.Text = "Order Date";
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Delete.Location = new System.Drawing.Point(15, 357);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 28);
            this.Delete.TabIndex = 46;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // SalesOrdersCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 394);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.orderDatePicker);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.customerLocationCodeField);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.locationCodeField);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.variantCodeField);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.shipmentDatePicker);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.unitOfMeasureField);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.quantityField);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.salesPriceField);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.itemDescriptionField);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.itemCodeField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.descriptionField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.customerCodeField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.salesOrderNoField);
            this.Controls.Add(this.label1);
            this.Name = "SalesOrdersCard";
            this.Text = "SalesOrdersCard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox salesOrderNoField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox customerCodeField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox descriptionField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox itemCodeField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox itemDescriptionField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox salesPriceField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox quantityField;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox unitOfMeasureField;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker shipmentDatePicker;
        private System.Windows.Forms.TextBox variantCodeField;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox locationCodeField;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox customerLocationCodeField;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker orderDatePicker;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button Delete;
    }
}