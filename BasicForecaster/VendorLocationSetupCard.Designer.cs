namespace BasicForecaster
{
    partial class VendorLocationSetupCard
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
            this.Delete = new System.Windows.Forms.Button();
            this.descriptionField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.locationCodeField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.blockedCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Delete.Location = new System.Drawing.Point(12, 103);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 28);
            this.Delete.TabIndex = 11;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // descriptionField
            // 
            this.descriptionField.Location = new System.Drawing.Point(167, 34);
            this.descriptionField.Name = "descriptionField";
            this.descriptionField.Size = new System.Drawing.Size(257, 20);
            this.descriptionField.TabIndex = 9;
            this.descriptionField.TextChanged += new System.EventHandler(this.descriptionField_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Description";
            // 
            // locationCodeField
            // 
            this.locationCodeField.Location = new System.Drawing.Point(167, 6);
            this.locationCodeField.Name = "locationCodeField";
            this.locationCodeField.Size = new System.Drawing.Size(257, 20);
            this.locationCodeField.TabIndex = 7;
            this.locationCodeField.TextChanged += new System.EventHandler(this.locationCodeField_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Vendor Location Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Blocked";
            // 
            // blockedCheckBox
            // 
            this.blockedCheckBox.AutoSize = true;
            this.blockedCheckBox.Location = new System.Drawing.Point(167, 67);
            this.blockedCheckBox.Name = "blockedCheckBox";
            this.blockedCheckBox.Size = new System.Drawing.Size(15, 14);
            this.blockedCheckBox.TabIndex = 13;
            this.blockedCheckBox.UseVisualStyleBackColor = true;
            this.blockedCheckBox.CheckedChanged += new System.EventHandler(this.blockedCheckBox_CheckedChanged);
            // 
            // VendorLocationSetupCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 151);
            this.Controls.Add(this.blockedCheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.descriptionField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.locationCodeField);
            this.Controls.Add(this.label1);
            this.Name = "VendorLocationSetupCard";
            this.Text = "VendorLocationSetupCard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VendorLocationSetupCard_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TextBox descriptionField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox locationCodeField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox blockedCheckBox;
    }
}