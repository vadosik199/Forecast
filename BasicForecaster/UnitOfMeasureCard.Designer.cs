namespace BasicForecaster
{
    partial class UnitOfMeasureCard
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
            this.label1 = new System.Windows.Forms.Label();
            this.unitOfMeasureField = new System.Windows.Forms.TextBox();
            this.descriptionField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._Amit_R_devDataSet = new BasicForecaster._Amit_R_devDataSet();
            this.unitOfMeasureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unit_of_MeasureTableAdapter = new BasicForecaster._Amit_R_devDataSetTableAdapters.Unit_of_MeasureTableAdapter();
            this.New = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.dbContextBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._Amit_R_devDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfMeasureBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbContextBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unit of Measure";
            // 
            // unitOfMeasureField
            // 
            this.unitOfMeasureField.Location = new System.Drawing.Point(126, 8);
            this.unitOfMeasureField.Name = "unitOfMeasureField";
            this.unitOfMeasureField.Size = new System.Drawing.Size(257, 20);
            this.unitOfMeasureField.TabIndex = 1;
            this.unitOfMeasureField.TextChanged += new System.EventHandler(this.unitOfMeasureField_TextChanged);
            // 
            // descriptionField
            // 
            this.descriptionField.Location = new System.Drawing.Point(126, 34);
            this.descriptionField.Name = "descriptionField";
            this.descriptionField.Size = new System.Drawing.Size(257, 20);
            this.descriptionField.TabIndex = 3;
            this.descriptionField.TextChanged += new System.EventHandler(this.descriptionField_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            // 
            // _Amit_R_devDataSet
            // 
            this._Amit_R_devDataSet.DataSetName = "_Amit_R_devDataSet";
            this._Amit_R_devDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // unitOfMeasureBindingSource
            // 
            this.unitOfMeasureBindingSource.DataMember = "Unit of Measure";
            this.unitOfMeasureBindingSource.DataSource = this._Amit_R_devDataSet;
            // 
            // unit_of_MeasureTableAdapter
            // 
            this.unit_of_MeasureTableAdapter.ClearBeforeFill = true;
            // 
            // New
            // 
            this.New.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.New.Location = new System.Drawing.Point(12, 80);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(75, 28);
            this.New.TabIndex = 4;
            this.New.Text = "New";
            this.New.UseVisualStyleBackColor = true;
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Delete.Location = new System.Drawing.Point(93, 80);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 28);
            this.Delete.TabIndex = 5;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // dbContextBindingSource
            // 
            this.dbContextBindingSource.DataSource = typeof(BasicForecaster.Models.dbContext);
            // 
            // UnitOfMeasureCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 120);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.New);
            this.Controls.Add(this.descriptionField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.unitOfMeasureField);
            this.Controls.Add(this.label1);
            this.Name = "UnitOfMeasureCard";
            this.Text = "UnitOfMeasureCard";
            this.Load += new System.EventHandler(this.UnitOfMeasureCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this._Amit_R_devDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfMeasureBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbContextBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox unitOfMeasureField;
        private System.Windows.Forms.TextBox descriptionField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource dbContextBindingSource;
        private _Amit_R_devDataSet _Amit_R_devDataSet;
        private System.Windows.Forms.BindingSource unitOfMeasureBindingSource;
        private _Amit_R_devDataSetTableAdapters.Unit_of_MeasureTableAdapter unit_of_MeasureTableAdapter;
        private System.Windows.Forms.Button New;
        private System.Windows.Forms.Button Delete;
    }
}