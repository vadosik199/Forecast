namespace BasicForecaster
{
    partial class CustomerLocationCard
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
            this.storeNoField = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.blockedCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.descriptionField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.customerLocationNoField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.posDataExistField = new System.Windows.Forms.TextBox();
            this.NewButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // storeNoField
            // 
            this.storeNoField.Location = new System.Drawing.Point(191, 111);
            this.storeNoField.Name = "storeNoField";
            this.storeNoField.Size = new System.Drawing.Size(257, 20);
            this.storeNoField.TabIndex = 51;
            this.storeNoField.TextChanged += new System.EventHandler(this.storeNoField_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(9, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 50;
            this.label5.Text = "Store No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(9, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 48;
            this.label4.Text = "POS Data Exist";
            // 
            // blockedCheckBox
            // 
            this.blockedCheckBox.AutoSize = true;
            this.blockedCheckBox.Location = new System.Drawing.Point(191, 69);
            this.blockedCheckBox.Name = "blockedCheckBox";
            this.blockedCheckBox.Size = new System.Drawing.Size(15, 14);
            this.blockedCheckBox.TabIndex = 47;
            this.blockedCheckBox.UseVisualStyleBackColor = true;
            this.blockedCheckBox.CheckedChanged += new System.EventHandler(this.blockedCheckBox_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(9, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 46;
            this.label3.Text = "Blocked";
            // 
            // descriptionField
            // 
            this.descriptionField.Location = new System.Drawing.Point(191, 38);
            this.descriptionField.Name = "descriptionField";
            this.descriptionField.Size = new System.Drawing.Size(257, 20);
            this.descriptionField.TabIndex = 45;
            this.descriptionField.TextChanged += new System.EventHandler(this.descriptionField_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(9, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 44;
            this.label2.Text = "Description";
            // 
            // customerLocationNoField
            // 
            this.customerLocationNoField.Location = new System.Drawing.Point(191, 12);
            this.customerLocationNoField.Name = "customerLocationNoField";
            this.customerLocationNoField.Size = new System.Drawing.Size(257, 20);
            this.customerLocationNoField.TabIndex = 43;
            this.customerLocationNoField.TextChanged += new System.EventHandler(this.customerLocationNoField_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 17);
            this.label1.TabIndex = 42;
            this.label1.Text = "Customer Location Code";
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Delete.Location = new System.Drawing.Point(13, 145);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 28);
            this.Delete.TabIndex = 52;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // posDataExistField
            // 
            this.posDataExistField.Location = new System.Drawing.Point(190, 86);
            this.posDataExistField.Name = "posDataExistField";
            this.posDataExistField.Size = new System.Drawing.Size(257, 20);
            this.posDataExistField.TabIndex = 53;
            this.posDataExistField.TextChanged += new System.EventHandler(this.posDataExistField_TextChanged);
            // 
            // NewButton
            // 
            this.NewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NewButton.Location = new System.Drawing.Point(94, 145);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(75, 28);
            this.NewButton.TabIndex = 54;
            this.NewButton.Text = "New";
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SaveButton.Location = new System.Drawing.Point(12, 145);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 28);
            this.SaveButton.TabIndex = 55;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CustomerLocationCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 183);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.NewButton);
            this.Controls.Add(this.posDataExistField);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.storeNoField);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.blockedCheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.descriptionField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customerLocationNoField);
            this.Controls.Add(this.label1);
            this.Name = "CustomerLocationCard";
            this.Text = "CustomerLocationCard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomerLocationCard_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox storeNoField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox blockedCheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox descriptionField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox customerLocationNoField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TextBox posDataExistField;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Button SaveButton;
    }
}