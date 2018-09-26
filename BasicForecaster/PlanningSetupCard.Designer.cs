namespace BasicForecaster
{
    partial class PlanningSetupCard
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
            this.idField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reorderPointField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.reorderQuantityField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lotAccumulationPeriodComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.forecastPeriodAggregationPreferenceComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.forwardBackwardConsumptionUOMComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.forwardConsumptionField = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.backwardConsumptionField = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.safetyStockQtyField = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.safetyStockLeadTimeUOMComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.safetyStockLeadTimeField = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.noOfPeriodToForecastField = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.periodsToBeUsedForHistoryUOMComboBox = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.periodsToBeUsedForHistoryField = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.deportRequirementPlanningCheckBox = new System.Windows.Forms.CheckBox();
            this.NewButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idField
            // 
            this.idField.Location = new System.Drawing.Point(275, 12);
            this.idField.Name = "idField";
            this.idField.Size = new System.Drawing.Size(257, 20);
            this.idField.TabIndex = 17;
            this.idField.TextChanged += new System.EventHandler(this.idField_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "ID";
            // 
            // reorderPointField
            // 
            this.reorderPointField.Location = new System.Drawing.Point(275, 38);
            this.reorderPointField.Name = "reorderPointField";
            this.reorderPointField.Size = new System.Drawing.Size(257, 20);
            this.reorderPointField.TabIndex = 19;
            this.reorderPointField.TextChanged += new System.EventHandler(this.reorderPointField_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Reorder Point";
            // 
            // reorderQuantityField
            // 
            this.reorderQuantityField.Location = new System.Drawing.Point(275, 64);
            this.reorderQuantityField.Name = "reorderQuantityField";
            this.reorderQuantityField.Size = new System.Drawing.Size(257, 20);
            this.reorderQuantityField.TabIndex = 21;
            this.reorderQuantityField.TextChanged += new System.EventHandler(this.reorderQuantityField_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(6, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Reorder Quantity";
            // 
            // lotAccumulationPeriodComboBox
            // 
            this.lotAccumulationPeriodComboBox.FormattingEnabled = true;
            this.lotAccumulationPeriodComboBox.Location = new System.Drawing.Point(275, 90);
            this.lotAccumulationPeriodComboBox.Name = "lotAccumulationPeriodComboBox";
            this.lotAccumulationPeriodComboBox.Size = new System.Drawing.Size(257, 21);
            this.lotAccumulationPeriodComboBox.TabIndex = 35;
            this.lotAccumulationPeriodComboBox.SelectedIndexChanged += new System.EventHandler(this.lotAccumulationPeriodComboBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(6, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 17);
            this.label6.TabIndex = 34;
            this.label6.Text = "Lot Accumulation Period";
            // 
            // forecastPeriodAggregationPreferenceComboBox
            // 
            this.forecastPeriodAggregationPreferenceComboBox.FormattingEnabled = true;
            this.forecastPeriodAggregationPreferenceComboBox.Location = new System.Drawing.Point(275, 117);
            this.forecastPeriodAggregationPreferenceComboBox.Name = "forecastPeriodAggregationPreferenceComboBox";
            this.forecastPeriodAggregationPreferenceComboBox.Size = new System.Drawing.Size(257, 21);
            this.forecastPeriodAggregationPreferenceComboBox.TabIndex = 37;
            this.forecastPeriodAggregationPreferenceComboBox.SelectedIndexChanged += new System.EventHandler(this.forecastPeriodAggregationPreferenceComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(6, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(263, 17);
            this.label4.TabIndex = 36;
            this.label4.Text = "Forecast Period Aggregation Preference";
            // 
            // forwardBackwardConsumptionUOMComboBox
            // 
            this.forwardBackwardConsumptionUOMComboBox.FormattingEnabled = true;
            this.forwardBackwardConsumptionUOMComboBox.Location = new System.Drawing.Point(275, 144);
            this.forwardBackwardConsumptionUOMComboBox.Name = "forwardBackwardConsumptionUOMComboBox";
            this.forwardBackwardConsumptionUOMComboBox.Size = new System.Drawing.Size(257, 21);
            this.forwardBackwardConsumptionUOMComboBox.TabIndex = 39;
            this.forwardBackwardConsumptionUOMComboBox.SelectedIndexChanged += new System.EventHandler(this.forwardBackwardConsumptionUOMComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(6, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(246, 17);
            this.label5.TabIndex = 38;
            this.label5.Text = "Forward Backward Consumption UOM";
            // 
            // forwardConsumptionField
            // 
            this.forwardConsumptionField.Location = new System.Drawing.Point(275, 171);
            this.forwardConsumptionField.Name = "forwardConsumptionField";
            this.forwardConsumptionField.Size = new System.Drawing.Size(257, 20);
            this.forwardConsumptionField.TabIndex = 41;
            this.forwardConsumptionField.TextChanged += new System.EventHandler(this.forwardConsumptionField_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(6, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 17);
            this.label7.TabIndex = 40;
            this.label7.Text = "Forward Consumption";
            // 
            // backwardConsumptionField
            // 
            this.backwardConsumptionField.Location = new System.Drawing.Point(275, 197);
            this.backwardConsumptionField.Name = "backwardConsumptionField";
            this.backwardConsumptionField.Size = new System.Drawing.Size(257, 20);
            this.backwardConsumptionField.TabIndex = 43;
            this.backwardConsumptionField.TextChanged += new System.EventHandler(this.backwardConsumptionField_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(6, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 17);
            this.label8.TabIndex = 42;
            this.label8.Text = "Backward Consumption";
            // 
            // safetyStockQtyField
            // 
            this.safetyStockQtyField.Location = new System.Drawing.Point(275, 223);
            this.safetyStockQtyField.Name = "safetyStockQtyField";
            this.safetyStockQtyField.Size = new System.Drawing.Size(257, 20);
            this.safetyStockQtyField.TabIndex = 45;
            this.safetyStockQtyField.TextChanged += new System.EventHandler(this.safetyStockQtyField_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(6, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 17);
            this.label9.TabIndex = 44;
            this.label9.Text = "Safety Stock Qty";
            // 
            // safetyStockLeadTimeUOMComboBox
            // 
            this.safetyStockLeadTimeUOMComboBox.FormattingEnabled = true;
            this.safetyStockLeadTimeUOMComboBox.Location = new System.Drawing.Point(275, 249);
            this.safetyStockLeadTimeUOMComboBox.Name = "safetyStockLeadTimeUOMComboBox";
            this.safetyStockLeadTimeUOMComboBox.Size = new System.Drawing.Size(257, 21);
            this.safetyStockLeadTimeUOMComboBox.TabIndex = 47;
            this.safetyStockLeadTimeUOMComboBox.SelectedIndexChanged += new System.EventHandler(this.safetyStockLeadTimeUOMComboBox_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(6, 249);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(193, 17);
            this.label10.TabIndex = 46;
            this.label10.Text = "Safety Stock Lead time  UOM";
            // 
            // safetyStockLeadTimeField
            // 
            this.safetyStockLeadTimeField.Location = new System.Drawing.Point(275, 276);
            this.safetyStockLeadTimeField.Name = "safetyStockLeadTimeField";
            this.safetyStockLeadTimeField.Size = new System.Drawing.Size(257, 20);
            this.safetyStockLeadTimeField.TabIndex = 49;
            this.safetyStockLeadTimeField.TextChanged += new System.EventHandler(this.safetyStockLeadTimeField_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(6, 279);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(158, 17);
            this.label11.TabIndex = 48;
            this.label11.Text = "Safety Stock Lead Time";
            // 
            // noOfPeriodToForecastField
            // 
            this.noOfPeriodToForecastField.Location = new System.Drawing.Point(275, 302);
            this.noOfPeriodToForecastField.Name = "noOfPeriodToForecastField";
            this.noOfPeriodToForecastField.Size = new System.Drawing.Size(257, 20);
            this.noOfPeriodToForecastField.TabIndex = 51;
            this.noOfPeriodToForecastField.TextChanged += new System.EventHandler(this.noOfPeriodToForecastField_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.Location = new System.Drawing.Point(6, 305);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(162, 17);
            this.label12.TabIndex = 50;
            this.label12.Text = "No of Period to Forecast";
            // 
            // periodsToBeUsedForHistoryUOMComboBox
            // 
            this.periodsToBeUsedForHistoryUOMComboBox.FormattingEnabled = true;
            this.periodsToBeUsedForHistoryUOMComboBox.Location = new System.Drawing.Point(275, 328);
            this.periodsToBeUsedForHistoryUOMComboBox.Name = "periodsToBeUsedForHistoryUOMComboBox";
            this.periodsToBeUsedForHistoryUOMComboBox.Size = new System.Drawing.Size(257, 21);
            this.periodsToBeUsedForHistoryUOMComboBox.TabIndex = 53;
            this.periodsToBeUsedForHistoryUOMComboBox.SelectedIndexChanged += new System.EventHandler(this.periodsToBeUsedForHistoryUOMComboBox_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.Location = new System.Drawing.Point(6, 328);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(230, 17);
            this.label13.TabIndex = 52;
            this.label13.Text = "Periods to be used for history UOM";
            // 
            // periodsToBeUsedForHistoryField
            // 
            this.periodsToBeUsedForHistoryField.Location = new System.Drawing.Point(275, 355);
            this.periodsToBeUsedForHistoryField.Name = "periodsToBeUsedForHistoryField";
            this.periodsToBeUsedForHistoryField.Size = new System.Drawing.Size(257, 20);
            this.periodsToBeUsedForHistoryField.TabIndex = 55;
            this.periodsToBeUsedForHistoryField.TextChanged += new System.EventHandler(this.periodsToBeUsedForHistoryField_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label14.Location = new System.Drawing.Point(6, 358);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(194, 17);
            this.label14.TabIndex = 54;
            this.label14.Text = "Periods to be used for history";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label15.Location = new System.Drawing.Point(6, 384);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(195, 17);
            this.label15.TabIndex = 56;
            this.label15.Text = "Deport Requirement Planning";
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Delete.Location = new System.Drawing.Point(9, 410);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 28);
            this.Delete.TabIndex = 58;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // deportRequirementPlanningCheckBox
            // 
            this.deportRequirementPlanningCheckBox.AutoSize = true;
            this.deportRequirementPlanningCheckBox.Location = new System.Drawing.Point(275, 387);
            this.deportRequirementPlanningCheckBox.Name = "deportRequirementPlanningCheckBox";
            this.deportRequirementPlanningCheckBox.Size = new System.Drawing.Size(15, 14);
            this.deportRequirementPlanningCheckBox.TabIndex = 59;
            this.deportRequirementPlanningCheckBox.UseVisualStyleBackColor = true;
            this.deportRequirementPlanningCheckBox.CheckedChanged += new System.EventHandler(this.deportRequirementPlanningCheckBox_CheckedChanged);
            // 
            // NewButton
            // 
            this.NewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NewButton.Location = new System.Drawing.Point(90, 410);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(75, 28);
            this.NewButton.TabIndex = 60;
            this.NewButton.Text = "New";
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SaveButton.Location = new System.Drawing.Point(9, 410);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 28);
            this.SaveButton.TabIndex = 61;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // PlanningSetupCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 450);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.NewButton);
            this.Controls.Add(this.deportRequirementPlanningCheckBox);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.periodsToBeUsedForHistoryField);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.periodsToBeUsedForHistoryUOMComboBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.noOfPeriodToForecastField);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.safetyStockLeadTimeField);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.safetyStockLeadTimeUOMComboBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.safetyStockQtyField);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.backwardConsumptionField);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.forwardConsumptionField);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.forwardBackwardConsumptionUOMComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.forecastPeriodAggregationPreferenceComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lotAccumulationPeriodComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.reorderQuantityField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.reorderPointField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idField);
            this.Controls.Add(this.label1);
            this.Name = "PlanningSetupCard";
            this.Text = "PlanningSetupCard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlanningSetupCard_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox reorderPointField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox reorderQuantityField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox lotAccumulationPeriodComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox forecastPeriodAggregationPreferenceComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox forwardBackwardConsumptionUOMComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox forwardConsumptionField;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox backwardConsumptionField;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox safetyStockQtyField;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox safetyStockLeadTimeUOMComboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox safetyStockLeadTimeField;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox noOfPeriodToForecastField;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox periodsToBeUsedForHistoryUOMComboBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox periodsToBeUsedForHistoryField;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.CheckBox deportRequirementPlanningCheckBox;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Button SaveButton;
    }
}