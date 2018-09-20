namespace BasicForecaster
{
    partial class OptimizationLevelCard
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
            this.fromMADField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toMADField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // codeField
            // 
            this.codeField.Location = new System.Drawing.Point(166, 12);
            this.codeField.Name = "codeField";
            this.codeField.Size = new System.Drawing.Size(257, 20);
            this.codeField.TabIndex = 17;
            this.codeField.TextChanged += new System.EventHandler(this.codeField_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Code";
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
            // fromMADField
            // 
            this.fromMADField.Location = new System.Drawing.Point(166, 64);
            this.fromMADField.Name = "fromMADField";
            this.fromMADField.Size = new System.Drawing.Size(257, 20);
            this.fromMADField.TabIndex = 21;
            this.fromMADField.TextChanged += new System.EventHandler(this.fromMADField_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(11, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "From MAD";
            // 
            // toMADField
            // 
            this.toMADField.Location = new System.Drawing.Point(166, 90);
            this.toMADField.Name = "toMADField";
            this.toMADField.Size = new System.Drawing.Size(257, 20);
            this.toMADField.TabIndex = 23;
            this.toMADField.TextChanged += new System.EventHandler(this.toMADField_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(11, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "To MAD";
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Delete.Location = new System.Drawing.Point(14, 125);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 28);
            this.Delete.TabIndex = 24;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // OptimizationLevelCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 169);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.toMADField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fromMADField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.descriptionField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.codeField);
            this.Controls.Add(this.label1);
            this.Name = "OptimizationLevelCard";
            this.Text = "OptimizationLevelCard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OptimizationLevelCard_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox codeField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox descriptionField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fromMADField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox toMADField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Delete;
    }
}