﻿namespace BasicForecaster
{
    partial class HistoryList
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
            this.historyDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.historyDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // historyDataGrid
            // 
            this.historyDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.historyDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historyDataGrid.Location = new System.Drawing.Point(12, 12);
            this.historyDataGrid.Name = "historyDataGrid";
            this.historyDataGrid.Size = new System.Drawing.Size(776, 426);
            this.historyDataGrid.TabIndex = 0;
            this.historyDataGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.historyDataGrid_CellMouseDoubleClick);
            this.historyDataGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.historyDataGrid_CellValueChanged);
            this.historyDataGrid.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.historyDataGrid_RowsAdded);
            this.historyDataGrid.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.historyDataGrid_RowsRemoved);
            // 
            // HistoryList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.historyDataGrid);
            this.Name = "HistoryList";
            this.Text = "HistoryList";
            ((System.ComponentModel.ISupportInitialize)(this.historyDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView historyDataGrid;
    }
}