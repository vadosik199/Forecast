namespace BasicForecaster
{
    partial class GeneralSetupCard
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
            this.companyNoField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.companyNameField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // companyNoField
            // 
            this.companyNoField.Location = new System.Drawing.Point(191, 12);
            this.companyNoField.Name = "companyNoField";
            this.companyNoField.Size = new System.Drawing.Size(257, 20);
            this.companyNoField.TabIndex = 35;
            this.companyNoField.TextChanged += new System.EventHandler(this.companyNoField_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Company No.";
            // 
            // companyNameField
            // 
            this.companyNameField.Location = new System.Drawing.Point(191, 38);
            this.companyNameField.Name = "companyNameField";
            this.companyNameField.Size = new System.Drawing.Size(257, 20);
            this.companyNameField.TabIndex = 37;
            this.companyNameField.TextChanged += new System.EventHandler(this.companyNameField_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(9, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "Company Name";
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Delete.Location = new System.Drawing.Point(12, 78);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 28);
            this.Delete.TabIndex = 47;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // GeneralSetupCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 122);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.companyNameField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.companyNoField);
            this.Controls.Add(this.label1);
            this.Name = "GeneralSetupCard";
            this.Text = "GeneralSetupCard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GeneralSetupCard_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox companyNoField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox companyNameField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Delete;
    }
}