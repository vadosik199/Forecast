namespace BasicForecaster
{
    partial class AssemblyProductionOrdersCard
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
            this.productionOrderNoField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.itemCodeField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.itemDescriptionField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.quantityToMakeField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.unitOfMeasureField = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.expectedCompletionDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.variantCodeField = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.locationCodeField = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.orderDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.NewButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // productionOrderNoField
            // 
            this.productionOrderNoField.Location = new System.Drawing.Point(196, 12);
            this.productionOrderNoField.Name = "productionOrderNoField";
            this.productionOrderNoField.Size = new System.Drawing.Size(257, 20);
            this.productionOrderNoField.TabIndex = 49;
            this.productionOrderNoField.TextChanged += new System.EventHandler(this.productionOrderNoField_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 17);
            this.label1.TabIndex = 48;
            this.label1.Text = "Production Order No";
            // 
            // itemCodeField
            // 
            this.itemCodeField.Location = new System.Drawing.Point(196, 38);
            this.itemCodeField.Name = "itemCodeField";
            this.itemCodeField.Size = new System.Drawing.Size(257, 20);
            this.itemCodeField.TabIndex = 51;
            this.itemCodeField.TextChanged += new System.EventHandler(this.itemCodeField_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(14, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 50;
            this.label2.Text = "Item Code";
            // 
            // itemDescriptionField
            // 
            this.itemDescriptionField.Location = new System.Drawing.Point(196, 64);
            this.itemDescriptionField.Name = "itemDescriptionField";
            this.itemDescriptionField.Size = new System.Drawing.Size(257, 20);
            this.itemDescriptionField.TabIndex = 53;
            this.itemDescriptionField.TextChanged += new System.EventHandler(this.itemDescriptionField_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(14, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 52;
            this.label3.Text = "Item Description";
            // 
            // quantityToMakeField
            // 
            this.quantityToMakeField.Location = new System.Drawing.Point(196, 90);
            this.quantityToMakeField.Name = "quantityToMakeField";
            this.quantityToMakeField.Size = new System.Drawing.Size(257, 20);
            this.quantityToMakeField.TabIndex = 55;
            this.quantityToMakeField.TextChanged += new System.EventHandler(this.quantityToMakeField_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(14, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 54;
            this.label4.Text = "Quantity to Make";
            // 
            // unitOfMeasureField
            // 
            this.unitOfMeasureField.Location = new System.Drawing.Point(196, 116);
            this.unitOfMeasureField.Name = "unitOfMeasureField";
            this.unitOfMeasureField.Size = new System.Drawing.Size(257, 20);
            this.unitOfMeasureField.TabIndex = 57;
            this.unitOfMeasureField.TextChanged += new System.EventHandler(this.unitOfMeasureField_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(14, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 56;
            this.label5.Text = "Unit of Measure";
            // 
            // expectedCompletionDatePicker
            // 
            this.expectedCompletionDatePicker.Location = new System.Drawing.Point(196, 142);
            this.expectedCompletionDatePicker.Name = "expectedCompletionDatePicker";
            this.expectedCompletionDatePicker.Size = new System.Drawing.Size(257, 20);
            this.expectedCompletionDatePicker.TabIndex = 67;
            this.expectedCompletionDatePicker.ValueChanged += new System.EventHandler(this.expectedCompletionDatePicker_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(14, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(174, 17);
            this.label10.TabIndex = 66;
            this.label10.Text = "Expected Completion Date";
            // 
            // variantCodeField
            // 
            this.variantCodeField.Location = new System.Drawing.Point(196, 168);
            this.variantCodeField.Name = "variantCodeField";
            this.variantCodeField.Size = new System.Drawing.Size(257, 20);
            this.variantCodeField.TabIndex = 69;
            this.variantCodeField.TextChanged += new System.EventHandler(this.variantCodeField_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(14, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 17);
            this.label6.TabIndex = 68;
            this.label6.Text = "Variant Code";
            // 
            // locationCodeField
            // 
            this.locationCodeField.Location = new System.Drawing.Point(196, 194);
            this.locationCodeField.Name = "locationCodeField";
            this.locationCodeField.Size = new System.Drawing.Size(257, 20);
            this.locationCodeField.TabIndex = 71;
            this.locationCodeField.TextChanged += new System.EventHandler(this.locationCodeField_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(14, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 17);
            this.label7.TabIndex = 70;
            this.label7.Text = "Location Code";
            // 
            // orderDatePicker
            // 
            this.orderDatePicker.Location = new System.Drawing.Point(196, 220);
            this.orderDatePicker.Name = "orderDatePicker";
            this.orderDatePicker.Size = new System.Drawing.Size(257, 20);
            this.orderDatePicker.TabIndex = 73;
            this.orderDatePicker.ValueChanged += new System.EventHandler(this.orderDatePicker_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(14, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 17);
            this.label8.TabIndex = 72;
            this.label8.Text = "Order Date";
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Delete.Location = new System.Drawing.Point(17, 259);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 28);
            this.Delete.TabIndex = 74;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // NewButton
            // 
            this.NewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NewButton.Location = new System.Drawing.Point(98, 259);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(75, 28);
            this.NewButton.TabIndex = 75;
            this.NewButton.Text = "New";
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SaveButton.Location = new System.Drawing.Point(17, 259);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 28);
            this.SaveButton.TabIndex = 76;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AssemblyProductionOrdersCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 305);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.NewButton);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.orderDatePicker);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.locationCodeField);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.variantCodeField);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.expectedCompletionDatePicker);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.unitOfMeasureField);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.quantityToMakeField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.itemDescriptionField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.itemCodeField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productionOrderNoField);
            this.Controls.Add(this.label1);
            this.Name = "AssemblyProductionOrdersCard";
            this.Text = "AssemblyProductionOrdersCard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AssemblyProductionOrdersCard_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox productionOrderNoField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox itemCodeField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox itemDescriptionField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox quantityToMakeField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox unitOfMeasureField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker expectedCompletionDatePicker;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox variantCodeField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox locationCodeField;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker orderDatePicker;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Button SaveButton;
    }
}