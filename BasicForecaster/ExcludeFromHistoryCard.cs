using BasicForecaster.Interfaces;
using BasicForecaster.Models;
using BasicForecaster.Models.Setup;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicForecaster
{
    public partial class ExcludeFromHistoryCard : Form
    {
        private dbContext dataContext = null;
        private Exclude_From_History dataExcludeFromHistory = null;
        private IErrorHandler errorHandler;
        private Form parentForm;
        public bool IsNew { get; private set; }

        public ExcludeFromHistoryCard(Form parentForm, bool isNew = false)
        {
            InitializeComponent();
            dataContext = new dbContext();
            errorHandler = new WinFormErrorHandler();
            this.parentForm = parentForm;
            dataContext.Exclude_From_Histories.Load();
            dataExcludeFromHistory = new Exclude_From_History();
            IsNew = isNew;
            if (IsNew)
            {
                SaveButton.Visible = true;
                Delete.Visible = false;
                NewButton.Visible = false;
            }
        }

        public ExcludeFromHistoryCard(string itemNo, Form parentForm)
            :this(parentForm)
        {   
            dataExcludeFromHistory = dataContext.Exclude_From_Histories.Where(u => u.Item_No.Equals(itemNo)).FirstOrDefault();
            itemNoField.Text = dataExcludeFromHistory.Item_No;
            descriptionField.Text = dataExcludeFromHistory.Description;
            lineNoField.Text = dataExcludeFromHistory.Line_No == null ? "" : dataExcludeFromHistory.Line_No.ToString();
            fromDatePicker.Value = dataExcludeFromHistory.From_Date == null ? DateTime.Now : (DateTime)dataExcludeFromHistory.From_Date;
            toDatePicker.Value = dataExcludeFromHistory.To_Date == null ? DateTime.Now : (DateTime)dataExcludeFromHistory.To_Date;

            if (!IsNew)
            {
                itemNoField.Enabled = false;
                SaveButton.Visible = false;
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                dataContext.Exclude_From_Histories.Remove(dataExcludeFromHistory);
                dataContext.SaveChanges();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void itemNoField_TextChanged(object sender, EventArgs e)
        {
            dataExcludeFromHistory.Item_No = itemNoField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void descriptionField_TextChanged(object sender, EventArgs e)
        {
            dataExcludeFromHistory.Description = descriptionField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void lineNoField_TextChanged(object sender, EventArgs e)
        {
            int no;
            if (int.TryParse(lineNoField.Text, out no))
            {
                dataExcludeFromHistory.Line_No = no;
            }
            dataContext.SaveData(errorHandler);
        }

        private void fromDatePicker_ValueChanged(object sender, EventArgs e)
        {
            dataExcludeFromHistory.From_Date = fromDatePicker.Value;
            dataContext.SaveData(errorHandler);
        }

        private void toDatePicker_ValueChanged(object sender, EventArgs e)
        {
            dataExcludeFromHistory.To_Date = toDatePicker.Value;
            dataContext.SaveData(errorHandler);
        }

        private void RefreshParentForm()
        {
            parentForm.Refresh();
        }

        private void ExcludeFromHistoryCard_FormClosing(object sender, FormClosingEventArgs e)
        {
            dataContext.SaveData(errorHandler);
            RefreshParentForm();
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            ExcludeFromHistoryCard card = new ExcludeFromHistoryCard(parentForm, true);
            card.Show();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (dbContext context = new dbContext())
                {
                    if (string.IsNullOrEmpty(itemNoField.Text))
                    {
                        throw new Exception("Field 'Item No' can`t be empty!");
                    }
                    if (context.Exclude_From_Histories.Where(vs => vs.Item_No.Equals(itemNoField.Text)).FirstOrDefault() != null)
                    {
                        throw new Exception($"Record with 'Item No' = {itemNoField.Text} already exist!");
                    }
                    dataExcludeFromHistory.Item_No = itemNoField.Text;
                    dataExcludeFromHistory.Description = descriptionField.Text;
                    int no;
                    if (int.TryParse(lineNoField.Text, out no))
                    {
                        dataExcludeFromHistory.Line_No = no;
                    }
                    dataExcludeFromHistory.From_Date = fromDatePicker.Value;
                    dataExcludeFromHistory.To_Date = toDatePicker.Value;
                    context.Exclude_From_Histories.Add(dataExcludeFromHistory);
                    context.SaveData(errorHandler);
                    ExcludeFromHistoryCard card = new ExcludeFromHistoryCard(dataExcludeFromHistory.Item_No, parentForm);
                    card.Show();
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
