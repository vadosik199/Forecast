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
    public partial class UnitOfMeasureCard : Form
    {
        private dbContext dataContext = null;
        private UnitOfMeasure dataUnitOfMeasure = null;
        private bool isNew;
        public UnitOfMeasureCard(bool isNew = true)
        {
            InitializeComponent();
            dataContext = new dbContext();
            this.isNew = isNew;
            if (isNew)
            {
                New.Visible = false;
            }
        }

        public UnitOfMeasureCard(string entityId, bool isNew = true)
            : this(isNew)
        {
            dataContext.UnitOfMeasure.Load();
            dataUnitOfMeasure = dataContext.UnitOfMeasure.Where(u => u.UnitofMeasure.Equals(entityId)).FirstOrDefault();
            unitOfMeasureField.Text = dataUnitOfMeasure.UnitofMeasure;
            descriptionField.Text = dataUnitOfMeasure.Description;

        }

        private void UnitOfMeasureCard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Amit_R_devDataSet.Unit_of_Measure' table. You can move, or remove it, as needed.
            this.unit_of_MeasureTableAdapter.Fill(this._Amit_R_devDataSet.Unit_of_Measure);

        }

        private void New_Click(object sender, EventArgs e)
        {
            UnitOfMeasureCard newCard = new UnitOfMeasureCard();
            newCard.Show();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            UnitOfMeasure unitOfMeasure = dataContext.UnitOfMeasure.Where(u => u.UnitofMeasure.Equals(unitOfMeasureField.Text)).FirstOrDefault();
            try
            {
                dataContext.UnitOfMeasure.Remove(unitOfMeasure);
                dataContext.SaveChanges();
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void unitOfMeasureField_TextChanged(object sender, EventArgs e)
        {
            dataUnitOfMeasure.UnitofMeasure = unitOfMeasureField.Text;
            try
            {
                dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void descriptionField_TextChanged(object sender, EventArgs e)
        {
            dataUnitOfMeasure.Description = descriptionField.Text;
            try
            {
                dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
