namespace BasicForecaster
{
    partial class DBDataList
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
            this.components = new System.ComponentModel.Container();
            this.DBDataGrid = new System.Windows.Forms.DataGridView();
            this.amitRdevDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Amit_R_devDataSet = new BasicForecaster._Amit_R_devDataSet();
            this.dbContextBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DBDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amitRdevDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Amit_R_devDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbContextBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DBDataGrid
            // 
            this.DBDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DBDataGrid.AutoGenerateColumns = false;
            this.DBDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBDataGrid.DataSource = this.amitRdevDataSetBindingSource;
            this.DBDataGrid.Location = new System.Drawing.Point(12, 12);
            this.DBDataGrid.Name = "DBDataGrid";
            this.DBDataGrid.Size = new System.Drawing.Size(776, 426);
            this.DBDataGrid.TabIndex = 0;
            this.DBDataGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DBDataGrid_CellMouseDoubleClick);
            this.DBDataGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DBDataGrid_CellValueChanged);
            this.DBDataGrid.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DBDataGrid_RowsAdded);
            this.DBDataGrid.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.DBDataGrid_RowsRemoved);
            // 
            // amitRdevDataSetBindingSource
            // 
            this.amitRdevDataSetBindingSource.DataSource = this._Amit_R_devDataSet;
            this.amitRdevDataSetBindingSource.Position = 0;
            // 
            // _Amit_R_devDataSet
            // 
            this._Amit_R_devDataSet.DataSetName = "_Amit_R_devDataSet";
            this._Amit_R_devDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbContextBindingSource
            // 
            this.dbContextBindingSource.DataSource = typeof(BasicForecaster.Models.dbContext);
            // 
            // DBDataList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DBDataGrid);
            this.Name = "DBDataList";
            this.Text = "DBDataList";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DBDataList_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.DBDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amitRdevDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Amit_R_devDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbContextBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DBDataGrid;
        private System.Windows.Forms.BindingSource dbContextBindingSource;
        private System.Windows.Forms.BindingSource amitRdevDataSetBindingSource;
        private _Amit_R_devDataSet _Amit_R_devDataSet;
    }
}