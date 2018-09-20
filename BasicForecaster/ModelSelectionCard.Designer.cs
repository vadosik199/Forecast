namespace BasicForecaster
{
    partial class ModelSelectionCard
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
            this.exTrendCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.descriptionField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.codeField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.exSeasonalCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.exTrendAndSeasonalCheckBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exTrendCheckBox
            // 
            this.exTrendCheckBox.AutoSize = true;
            this.exTrendCheckBox.Location = new System.Drawing.Point(166, 73);
            this.exTrendCheckBox.Name = "exTrendCheckBox";
            this.exTrendCheckBox.Size = new System.Drawing.Size(15, 14);
            this.exTrendCheckBox.TabIndex = 26;
            this.exTrendCheckBox.UseVisualStyleBackColor = true;
            this.exTrendCheckBox.CheckedChanged += new System.EventHandler(this.exTrendCheckBox_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(11, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Ex Trend";
            // 
            // descriptionField
            // 
            this.descriptionField.Location = new System.Drawing.Point(166, 40);
            this.descriptionField.Name = "descriptionField";
            this.descriptionField.Size = new System.Drawing.Size(257, 20);
            this.descriptionField.TabIndex = 24;
            this.descriptionField.TextChanged += new System.EventHandler(this.descriptionField_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(11, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Description";
            // 
            // codeField
            // 
            this.codeField.Location = new System.Drawing.Point(166, 12);
            this.codeField.Name = "codeField";
            this.codeField.Size = new System.Drawing.Size(257, 20);
            this.codeField.TabIndex = 22;
            this.codeField.TextChanged += new System.EventHandler(this.codeField_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Code";
            // 
            // exSeasonalCheckBox
            // 
            this.exSeasonalCheckBox.AutoSize = true;
            this.exSeasonalCheckBox.Location = new System.Drawing.Point(166, 93);
            this.exSeasonalCheckBox.Name = "exSeasonalCheckBox";
            this.exSeasonalCheckBox.Size = new System.Drawing.Size(15, 14);
            this.exSeasonalCheckBox.TabIndex = 28;
            this.exSeasonalCheckBox.UseVisualStyleBackColor = true;
            this.exSeasonalCheckBox.CheckedChanged += new System.EventHandler(this.exSeasonalCheckBox_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(11, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Ex Seasonal";
            // 
            // exTrendAndSeasonalCheckBox
            // 
            this.exTrendAndSeasonalCheckBox.AutoSize = true;
            this.exTrendAndSeasonalCheckBox.Location = new System.Drawing.Point(166, 113);
            this.exTrendAndSeasonalCheckBox.Name = "exTrendAndSeasonalCheckBox";
            this.exTrendAndSeasonalCheckBox.Size = new System.Drawing.Size(15, 14);
            this.exTrendAndSeasonalCheckBox.TabIndex = 30;
            this.exTrendAndSeasonalCheckBox.UseVisualStyleBackColor = true;
            this.exTrendAndSeasonalCheckBox.CheckedChanged += new System.EventHandler(this.exTrendAndSeasonalCheckBox_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(11, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 17);
            this.label5.TabIndex = 29;
            this.label5.Text = "Ex Trend And Seasonal";
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Delete.Location = new System.Drawing.Point(14, 147);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 28);
            this.Delete.TabIndex = 31;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // ModelSelectionCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 188);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.exTrendAndSeasonalCheckBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.exSeasonalCheckBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.exTrendCheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.descriptionField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.codeField);
            this.Controls.Add(this.label1);
            this.Name = "ModelSelectionCard";
            this.Text = "ModelSelectionCard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModelSelectionCard_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox exTrendCheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox descriptionField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox codeField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox exSeasonalCheckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox exTrendAndSeasonalCheckBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Delete;
    }
}