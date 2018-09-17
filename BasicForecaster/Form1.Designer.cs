namespace BasicForecaster {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SetupButton = new System.Windows.Forms.Button();
            this.HistoryButton = new System.Windows.Forms.Button();
            this.ForecastButton = new System.Windows.Forms.Button();
            this.PlanningButton = new System.Windows.Forms.Button();
            this.ProcessButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SetupButton
            // 
            this.SetupButton.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu;
            this.SetupButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SetupButton.BackgroundImage")));
            this.SetupButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SetupButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SetupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SetupButton.Location = new System.Drawing.Point(12, 12);
            this.SetupButton.Name = "SetupButton";
            this.SetupButton.Size = new System.Drawing.Size(73, 125);
            this.SetupButton.TabIndex = 3;
            this.SetupButton.Text = "Setup";
            this.SetupButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SetupButton.UseVisualStyleBackColor = false;
            this.SetupButton.Click += new System.EventHandler(this.SetupButton_Click);
            // 
            // HistoryButton
            // 
            this.HistoryButton.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu;
            this.HistoryButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HistoryButton.BackgroundImage")));
            this.HistoryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.HistoryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HistoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.HistoryButton.Location = new System.Drawing.Point(91, 12);
            this.HistoryButton.Name = "HistoryButton";
            this.HistoryButton.Size = new System.Drawing.Size(73, 125);
            this.HistoryButton.TabIndex = 4;
            this.HistoryButton.Text = "History";
            this.HistoryButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.HistoryButton.UseVisualStyleBackColor = false;
            this.HistoryButton.Click += new System.EventHandler(this.HistoryButton_Click);
            // 
            // ForecastButton
            // 
            this.ForecastButton.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu;
            this.ForecastButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ForecastButton.BackgroundImage")));
            this.ForecastButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ForecastButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForecastButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ForecastButton.Location = new System.Drawing.Point(170, 12);
            this.ForecastButton.Name = "ForecastButton";
            this.ForecastButton.Size = new System.Drawing.Size(73, 125);
            this.ForecastButton.TabIndex = 5;
            this.ForecastButton.Text = "Forecast";
            this.ForecastButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ForecastButton.UseVisualStyleBackColor = false;
            this.ForecastButton.Click += new System.EventHandler(this.ForecastButton_Click);
            // 
            // PlanningButton
            // 
            this.PlanningButton.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu;
            this.PlanningButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PlanningButton.BackgroundImage")));
            this.PlanningButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PlanningButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlanningButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PlanningButton.Location = new System.Drawing.Point(249, 12);
            this.PlanningButton.Name = "PlanningButton";
            this.PlanningButton.Size = new System.Drawing.Size(73, 125);
            this.PlanningButton.TabIndex = 6;
            this.PlanningButton.Text = "Planning";
            this.PlanningButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.PlanningButton.UseVisualStyleBackColor = false;
            // 
            // ProcessButton
            // 
            this.ProcessButton.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu;
            this.ProcessButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ProcessButton.BackgroundImage")));
            this.ProcessButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ProcessButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProcessButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ProcessButton.Location = new System.Drawing.Point(328, 12);
            this.ProcessButton.Name = "ProcessButton";
            this.ProcessButton.Size = new System.Drawing.Size(73, 125);
            this.ProcessButton.TabIndex = 7;
            this.ProcessButton.Text = "Process";
            this.ProcessButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ProcessButton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(412, 149);
            this.Controls.Add(this.ProcessButton);
            this.Controls.Add(this.PlanningButton);
            this.Controls.Add(this.ForecastButton);
            this.Controls.Add(this.HistoryButton);
            this.Controls.Add(this.SetupButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button SetupButton;
        private System.Windows.Forms.Button HistoryButton;
        private System.Windows.Forms.Button ForecastButton;
        private System.Windows.Forms.Button PlanningButton;
        private System.Windows.Forms.Button ProcessButton;
    }
}

