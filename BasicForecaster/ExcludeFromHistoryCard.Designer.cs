namespace BasicForecaster
{
    partial class ExcludeFromHistoryCard
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
            this.itemNoField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.descriptionField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lineNoField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.toDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // itemNoField
            // 
            this.itemNoField.Location = new System.Drawing.Point(166, 12);
            this.itemNoField.Name = "itemNoField";
            this.itemNoField.Size = new System.Drawing.Size(257, 20);
            this.itemNoField.TabIndex = 17;
            this.itemNoField.TextChanged += new System.EventHandler(this.itemNoField_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Item No";
            // 
            // descriptionField
            // 
            this.descriptionField.Location = new System.Drawing.Point(166, 38);
            this.descriptionField.Name = "descriptionField";
            this.descriptionField.Size = new System.Drawing.Size(257, 20);
            this.descriptionField.TabIndex = 19;
            this.descriptionField.TextChanged += new System.EventHandler(this.descriptionField_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(11, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Description";
            // 
            // lineNoField
            // 
            this.lineNoField.Location = new System.Drawing.Point(166, 64);
            this.lineNoField.Name = "lineNoField";
            this.lineNoField.Size = new System.Drawing.Size(257, 20);
            this.lineNoField.TabIndex = 21;
            this.lineNoField.TextChanged += new System.EventHandler(this.lineNoField_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(11, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Line No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(11, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "From Date";
            // 
            // fromDatePicker
            // 
            this.fromDatePicker.Location = new System.Drawing.Point(166, 93);
            this.fromDatePicker.Name = "fromDatePicker";
            this.fromDatePicker.Size = new System.Drawing.Size(257, 20);
            this.fromDatePicker.TabIndex = 23;
            this.fromDatePicker.ValueChanged += new System.EventHandler(this.fromDatePicker_ValueChanged);
            // 
            // toDatePicker
            // 
            this.toDatePicker.Location = new System.Drawing.Point(166, 119);
            this.toDatePicker.Name = "toDatePicker";
            this.toDatePicker.Size = new System.Drawing.Size(257, 20);
            this.toDatePicker.TabIndex = 25;
            this.toDatePicker.ValueChanged += new System.EventHandler(this.toDatePicker_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(11, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "To Date";
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Delete.Location = new System.Drawing.Point(14, 152);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 28);
            this.Delete.TabIndex = 26;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // ExcludeFromHistoryCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 198);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.toDatePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fromDatePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lineNoField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.descriptionField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.itemNoField);
            this.Controls.Add(this.label1);
            this.Name = "ExcludeFromHistoryCard";
            this.Text = "ExcludeFromHistoryCard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExcludeFromHistoryCard_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox itemNoField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox descriptionField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lineNoField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker fromDatePicker;
        private System.Windows.Forms.DateTimePicker toDatePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Delete;
    }
}