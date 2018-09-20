namespace BasicForecaster
{
    partial class UserSetupCard
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
            this.userIdField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.firstNameField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.middleNameField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lastNameField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.permissionField = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userIdField
            // 
            this.userIdField.Location = new System.Drawing.Point(191, 12);
            this.userIdField.Name = "userIdField";
            this.userIdField.Size = new System.Drawing.Size(257, 20);
            this.userIdField.TabIndex = 35;
            this.userIdField.TextChanged += new System.EventHandler(this.userIdField_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "User ID";
            // 
            // firstNameField
            // 
            this.firstNameField.Location = new System.Drawing.Point(191, 38);
            this.firstNameField.Name = "firstNameField";
            this.firstNameField.Size = new System.Drawing.Size(257, 20);
            this.firstNameField.TabIndex = 37;
            this.firstNameField.TextChanged += new System.EventHandler(this.firstNameField_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(9, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "First Name";
            // 
            // middleNameField
            // 
            this.middleNameField.Location = new System.Drawing.Point(191, 64);
            this.middleNameField.Name = "middleNameField";
            this.middleNameField.Size = new System.Drawing.Size(257, 20);
            this.middleNameField.TabIndex = 39;
            this.middleNameField.TextChanged += new System.EventHandler(this.middleNameField_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(9, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = "Middle Name";
            // 
            // lastNameField
            // 
            this.lastNameField.Location = new System.Drawing.Point(191, 90);
            this.lastNameField.Name = "lastNameField";
            this.lastNameField.Size = new System.Drawing.Size(257, 20);
            this.lastNameField.TabIndex = 41;
            this.lastNameField.TextChanged += new System.EventHandler(this.lastNameField_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(9, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 40;
            this.label4.Text = "Last Name";
            // 
            // passwordField
            // 
            this.passwordField.Location = new System.Drawing.Point(191, 116);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(257, 20);
            this.passwordField.TabIndex = 43;
            this.passwordField.TextChanged += new System.EventHandler(this.passwordField_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(9, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 42;
            this.label5.Text = "Password Field";
            // 
            // permissionField
            // 
            this.permissionField.Location = new System.Drawing.Point(191, 142);
            this.permissionField.Name = "permissionField";
            this.permissionField.Size = new System.Drawing.Size(257, 20);
            this.permissionField.TabIndex = 45;
            this.permissionField.TextChanged += new System.EventHandler(this.permissionField_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(9, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 44;
            this.label6.Text = "Permission";
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Delete.Location = new System.Drawing.Point(12, 186);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 28);
            this.Delete.TabIndex = 47;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // UserSetupCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 226);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.permissionField);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lastNameField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.middleNameField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.firstNameField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userIdField);
            this.Controls.Add(this.label1);
            this.Name = "UserSetupCard";
            this.Text = "UserSetupCard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserSetupCard_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userIdField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstNameField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox middleNameField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lastNameField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox permissionField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Delete;
    }
}