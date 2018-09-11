namespace BasicForecaster {
    partial class SalesHistoryList {
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
            this.components = new System.ComponentModel.Container();
            this._Amit_R_devDataSet1 = new BasicForecaster._Amit_R_devDataSet();
            this.amitRdevDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.salesHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sales_HistoryTableAdapter = new BasicForecaster._Amit_R_devDataSetTableAdapters.Sales_HistoryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this._Amit_R_devDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amitRdevDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesHistoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // _Amit_R_devDataSet1
            // 
            this._Amit_R_devDataSet1.DataSetName = "_Amit_R_devDataSet";
            this._Amit_R_devDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // amitRdevDataSet1BindingSource
            // 
            this.amitRdevDataSet1BindingSource.DataSource = this._Amit_R_devDataSet1;
            this.amitRdevDataSet1BindingSource.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(635, 333);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
            // 
            // salesHistoryBindingSource
            // 
            this.salesHistoryBindingSource.DataMember = "Sales History";
            this.salesHistoryBindingSource.DataSource = this.amitRdevDataSet1BindingSource;
            // 
            // sales_HistoryTableAdapter
            // 
            this.sales_HistoryTableAdapter.ClearBeforeFill = true;
            // 
            // SalesHistoryList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 357);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SalesHistoryList";
            this.Text = "SalesHistoryList";
            this.Load += new System.EventHandler(this.SalesHistoryList_Load);
            ((System.ComponentModel.ISupportInitialize)(this._Amit_R_devDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amitRdevDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesHistoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private _Amit_R_devDataSet _Amit_R_devDataSet1;
        private System.Windows.Forms.BindingSource amitRdevDataSet1BindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource salesHistoryBindingSource;
        private _Amit_R_devDataSetTableAdapters.Sales_HistoryTableAdapter sales_HistoryTableAdapter;
    }
}