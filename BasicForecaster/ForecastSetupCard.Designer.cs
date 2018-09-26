namespace BasicForecaster
{
    partial class ForecastSetupCard
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
            this.codeField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.descriptionField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.alphaFactorField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.betaFactorField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gammaFactorField = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.deltaFactorField = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.trackingLimitField = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.factorOptimizationCheckBox = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rankingField = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.simpleMAPeriodInMonthField = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.centeredMAPeriodInMonthField = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.forecastByCustomerCheckBox = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.forecastByCustomerLocationCheckBox = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.forecastByLocationCheckBox = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.forecastByVariantCheckBox = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.forecastByVendorCheckBox = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.overlapPeriodComboBox = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.NewButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // codeField
            // 
            this.codeField.Location = new System.Drawing.Point(224, 12);
            this.codeField.Name = "codeField";
            this.codeField.Size = new System.Drawing.Size(257, 20);
            this.codeField.TabIndex = 17;
            this.codeField.TextChanged += new System.EventHandler(this.codeField_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Code";
            // 
            // descriptionField
            // 
            this.descriptionField.Location = new System.Drawing.Point(224, 38);
            this.descriptionField.Name = "descriptionField";
            this.descriptionField.Size = new System.Drawing.Size(257, 20);
            this.descriptionField.TabIndex = 19;
            this.descriptionField.TextChanged += new System.EventHandler(this.descriptionField_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(14, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Description";
            // 
            // alphaFactorField
            // 
            this.alphaFactorField.Location = new System.Drawing.Point(224, 64);
            this.alphaFactorField.Name = "alphaFactorField";
            this.alphaFactorField.Size = new System.Drawing.Size(257, 20);
            this.alphaFactorField.TabIndex = 21;
            this.alphaFactorField.TextChanged += new System.EventHandler(this.alphaFactorField_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(14, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Alpha Factor";
            // 
            // betaFactorField
            // 
            this.betaFactorField.Location = new System.Drawing.Point(224, 90);
            this.betaFactorField.Name = "betaFactorField";
            this.betaFactorField.Size = new System.Drawing.Size(257, 20);
            this.betaFactorField.TabIndex = 23;
            this.betaFactorField.TextChanged += new System.EventHandler(this.betaFactorField_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(14, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Beta Factor";
            // 
            // gammaFactorField
            // 
            this.gammaFactorField.Location = new System.Drawing.Point(224, 116);
            this.gammaFactorField.Name = "gammaFactorField";
            this.gammaFactorField.Size = new System.Drawing.Size(257, 20);
            this.gammaFactorField.TabIndex = 25;
            this.gammaFactorField.TextChanged += new System.EventHandler(this.gammaFactorField_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(14, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Gamma Factor";
            // 
            // deltaFactorField
            // 
            this.deltaFactorField.Location = new System.Drawing.Point(224, 142);
            this.deltaFactorField.Name = "deltaFactorField";
            this.deltaFactorField.Size = new System.Drawing.Size(257, 20);
            this.deltaFactorField.TabIndex = 27;
            this.deltaFactorField.TextChanged += new System.EventHandler(this.deltaFactorField_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(14, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "Delta Factor";
            // 
            // trackingLimitField
            // 
            this.trackingLimitField.Location = new System.Drawing.Point(224, 168);
            this.trackingLimitField.Name = "trackingLimitField";
            this.trackingLimitField.Size = new System.Drawing.Size(257, 20);
            this.trackingLimitField.TabIndex = 29;
            this.trackingLimitField.TextChanged += new System.EventHandler(this.trackingLimitField_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(14, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 17);
            this.label7.TabIndex = 28;
            this.label7.Text = "Tracking Limit";
            // 
            // factorOptimizationCheckBox
            // 
            this.factorOptimizationCheckBox.AutoSize = true;
            this.factorOptimizationCheckBox.Location = new System.Drawing.Point(224, 194);
            this.factorOptimizationCheckBox.Name = "factorOptimizationCheckBox";
            this.factorOptimizationCheckBox.Size = new System.Drawing.Size(15, 14);
            this.factorOptimizationCheckBox.TabIndex = 31;
            this.factorOptimizationCheckBox.UseVisualStyleBackColor = true;
            this.factorOptimizationCheckBox.CheckedChanged += new System.EventHandler(this.factorOptimizationCheckBox_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(14, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 17);
            this.label8.TabIndex = 30;
            this.label8.Text = "Factor Optimization";
            // 
            // rankingField
            // 
            this.rankingField.Location = new System.Drawing.Point(224, 214);
            this.rankingField.Name = "rankingField";
            this.rankingField.Size = new System.Drawing.Size(257, 20);
            this.rankingField.TabIndex = 33;
            this.rankingField.TextChanged += new System.EventHandler(this.rankingField_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(14, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 17);
            this.label9.TabIndex = 32;
            this.label9.Text = "Ranking";
            // 
            // simpleMAPeriodInMonthField
            // 
            this.simpleMAPeriodInMonthField.Location = new System.Drawing.Point(224, 240);
            this.simpleMAPeriodInMonthField.Name = "simpleMAPeriodInMonthField";
            this.simpleMAPeriodInMonthField.Size = new System.Drawing.Size(257, 20);
            this.simpleMAPeriodInMonthField.TabIndex = 35;
            this.simpleMAPeriodInMonthField.TextChanged += new System.EventHandler(this.simpleMAPeriodInMonthField_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(14, 243);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(188, 17);
            this.label10.TabIndex = 34;
            this.label10.Text = "Simple M.A Period in Months";
            // 
            // centeredMAPeriodInMonthField
            // 
            this.centeredMAPeriodInMonthField.Location = new System.Drawing.Point(224, 266);
            this.centeredMAPeriodInMonthField.Name = "centeredMAPeriodInMonthField";
            this.centeredMAPeriodInMonthField.Size = new System.Drawing.Size(257, 20);
            this.centeredMAPeriodInMonthField.TabIndex = 37;
            this.centeredMAPeriodInMonthField.TextChanged += new System.EventHandler(this.centeredMAPeriodInMonthField_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(14, 269);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(204, 17);
            this.label11.TabIndex = 36;
            this.label11.Text = "Centered M.A Period in Months";
            // 
            // forecastByCustomerCheckBox
            // 
            this.forecastByCustomerCheckBox.AutoSize = true;
            this.forecastByCustomerCheckBox.Location = new System.Drawing.Point(224, 292);
            this.forecastByCustomerCheckBox.Name = "forecastByCustomerCheckBox";
            this.forecastByCustomerCheckBox.Size = new System.Drawing.Size(15, 14);
            this.forecastByCustomerCheckBox.TabIndex = 39;
            this.forecastByCustomerCheckBox.UseVisualStyleBackColor = true;
            this.forecastByCustomerCheckBox.CheckedChanged += new System.EventHandler(this.forecastByCustomerCheckBox_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.Location = new System.Drawing.Point(14, 290);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(146, 17);
            this.label12.TabIndex = 38;
            this.label12.Text = "Forecast by Customer";
            // 
            // forecastByCustomerLocationCheckBox
            // 
            this.forecastByCustomerLocationCheckBox.AutoSize = true;
            this.forecastByCustomerLocationCheckBox.Location = new System.Drawing.Point(224, 312);
            this.forecastByCustomerLocationCheckBox.Name = "forecastByCustomerLocationCheckBox";
            this.forecastByCustomerLocationCheckBox.Size = new System.Drawing.Size(15, 14);
            this.forecastByCustomerLocationCheckBox.TabIndex = 41;
            this.forecastByCustomerLocationCheckBox.UseVisualStyleBackColor = true;
            this.forecastByCustomerLocationCheckBox.CheckedChanged += new System.EventHandler(this.forecastByCustomerLocationCheckBox_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.Location = new System.Drawing.Point(14, 310);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(204, 17);
            this.label13.TabIndex = 40;
            this.label13.Text = "Forecast by Customer Location";
            // 
            // forecastByLocationCheckBox
            // 
            this.forecastByLocationCheckBox.AutoSize = true;
            this.forecastByLocationCheckBox.Location = new System.Drawing.Point(224, 332);
            this.forecastByLocationCheckBox.Name = "forecastByLocationCheckBox";
            this.forecastByLocationCheckBox.Size = new System.Drawing.Size(15, 14);
            this.forecastByLocationCheckBox.TabIndex = 43;
            this.forecastByLocationCheckBox.UseVisualStyleBackColor = true;
            this.forecastByLocationCheckBox.CheckedChanged += new System.EventHandler(this.forecastByLocationCheckBox_CheckedChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label14.Location = new System.Drawing.Point(14, 330);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(140, 17);
            this.label14.TabIndex = 42;
            this.label14.Text = "Forecast by Location";
            // 
            // forecastByVariantCheckBox
            // 
            this.forecastByVariantCheckBox.AutoSize = true;
            this.forecastByVariantCheckBox.Location = new System.Drawing.Point(224, 352);
            this.forecastByVariantCheckBox.Name = "forecastByVariantCheckBox";
            this.forecastByVariantCheckBox.Size = new System.Drawing.Size(15, 14);
            this.forecastByVariantCheckBox.TabIndex = 45;
            this.forecastByVariantCheckBox.UseVisualStyleBackColor = true;
            this.forecastByVariantCheckBox.CheckedChanged += new System.EventHandler(this.forecastByVariantCheckBox_CheckedChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label15.Location = new System.Drawing.Point(14, 350);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(131, 17);
            this.label15.TabIndex = 44;
            this.label15.Text = "Forecast by Variant";
            // 
            // forecastByVendorCheckBox
            // 
            this.forecastByVendorCheckBox.AutoSize = true;
            this.forecastByVendorCheckBox.Location = new System.Drawing.Point(224, 372);
            this.forecastByVendorCheckBox.Name = "forecastByVendorCheckBox";
            this.forecastByVendorCheckBox.Size = new System.Drawing.Size(15, 14);
            this.forecastByVendorCheckBox.TabIndex = 47;
            this.forecastByVendorCheckBox.UseVisualStyleBackColor = true;
            this.forecastByVendorCheckBox.CheckedChanged += new System.EventHandler(this.forecastByVendorCheckBox_CheckedChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label16.Location = new System.Drawing.Point(14, 370);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(132, 17);
            this.label16.TabIndex = 46;
            this.label16.Text = "Forecast by Vendor";
            // 
            // overlapPeriodComboBox
            // 
            this.overlapPeriodComboBox.FormattingEnabled = true;
            this.overlapPeriodComboBox.Location = new System.Drawing.Point(224, 392);
            this.overlapPeriodComboBox.Name = "overlapPeriodComboBox";
            this.overlapPeriodComboBox.Size = new System.Drawing.Size(257, 21);
            this.overlapPeriodComboBox.TabIndex = 49;
            this.overlapPeriodComboBox.SelectedIndexChanged += new System.EventHandler(this.overlapPeriodComboBox_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label17.Location = new System.Drawing.Point(15, 392);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(103, 17);
            this.label17.TabIndex = 48;
            this.label17.Text = "Overlap Period";
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Delete.Location = new System.Drawing.Point(17, 422);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 28);
            this.Delete.TabIndex = 50;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // NewButton
            // 
            this.NewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NewButton.Location = new System.Drawing.Point(98, 422);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(75, 28);
            this.NewButton.TabIndex = 51;
            this.NewButton.Text = "New";
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SaveButton.Location = new System.Drawing.Point(17, 422);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 28);
            this.SaveButton.TabIndex = 52;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ForecastSetupCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 462);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.NewButton);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.overlapPeriodComboBox);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.forecastByVendorCheckBox);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.forecastByVariantCheckBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.forecastByLocationCheckBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.forecastByCustomerLocationCheckBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.forecastByCustomerCheckBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.centeredMAPeriodInMonthField);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.simpleMAPeriodInMonthField);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.rankingField);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.factorOptimizationCheckBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.trackingLimitField);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.deltaFactorField);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gammaFactorField);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.betaFactorField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.alphaFactorField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.descriptionField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.codeField);
            this.Controls.Add(this.label1);
            this.Name = "ForecastSetupCard";
            this.Text = "ForecastSetupCard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ForecastSetupCard_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox codeField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox descriptionField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox alphaFactorField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox betaFactorField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox gammaFactorField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox deltaFactorField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox trackingLimitField;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox factorOptimizationCheckBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox rankingField;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox simpleMAPeriodInMonthField;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox centeredMAPeriodInMonthField;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox forecastByCustomerCheckBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox forecastByCustomerLocationCheckBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox forecastByLocationCheckBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox forecastByVariantCheckBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox forecastByVendorCheckBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox overlapPeriodComboBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Button SaveButton;
    }
}