using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicForecaster.Models;
using BasicForecaster.Models.Setup;

namespace BasicForecaster
{
    public partial class DBDataList : Form
    {
        private dbContext dataContext = null;
        private Type entityType;

        public DBDataList()
        {
            InitializeComponent();
            dataContext = new dbContext();
        }

        public DBDataList(SetupType setupType)
            :this()
        {
            DBDataGrid.AutoGenerateColumns = true;
            switch (setupType)
            {
                case SetupType.User:
                    dataContext.UserSetup.Load();
                    entityType = typeof(UserSetup);
                    DBDataGrid.DataSource = dataContext.UserSetup.Local.ToBindingList();
                    break;
                case SetupType.General:
                    dataContext.GeneralSetup.Load();
                    entityType = typeof(GeneralSetup);
                    DBDataGrid.DataSource = dataContext.GeneralSetup.Local.ToBindingList();
                    break;
                case SetupType.Item:
                    dataContext.ItemSetup.Load();
                    entityType = typeof(ItemSetup);
                    DBDataGrid.DataSource = dataContext.ItemSetup.Local.ToBindingList();
                    break;
                case SetupType.Variant:
                    dataContext.VariantSetup.Load();
                    entityType = typeof(VariantSetup);
                    DBDataGrid.DataSource = dataContext.VariantSetup.Local.ToBindingList();
                    break;
                case SetupType.BOM:
                    dataContext.BOMSetup.Load();
                    entityType = typeof(BOMSetup);
                    DBDataGrid.DataSource = dataContext.BOMSetup.Local.ToBindingList();
                    break;
                case SetupType.Customer:
                    dataContext.CustomerSetup.Load();
                    entityType = typeof(CustomerSetup);
                    DBDataGrid.DataSource = dataContext.CustomerSetup.Local.ToBindingList();
                    break;
                case SetupType.CustomerLocation:
                    dataContext.CustomerLocation.Load();
                    entityType = typeof(CustomerLocation);
                    DBDataGrid.DataSource = dataContext.CustomerLocation.Local.ToBindingList();
                    break;
                case SetupType.Vendor:
                    dataContext.VendorSetup.Load();
                    entityType = typeof(VendorSetup);
                    DBDataGrid.DataSource = dataContext.VendorSetup.Local.ToBindingList();
                    break;
                case SetupType.VendorLocation:
                    dataContext.VendorLocation.Load();
                    entityType = typeof(VendorLocation);
                    DBDataGrid.DataSource = dataContext.VendorLocation.Local.ToBindingList();
                    break;
                case SetupType.Location:
                    dataContext.LocationSetup.Load();
                    entityType = typeof(LocationSetup);
                    DBDataGrid.DataSource = dataContext.LocationSetup.Local.ToBindingList();
                    break;
                case SetupType.UnitOfMeasure:
                    dataContext.UnitOfMeasure.Load();
                    entityType = typeof(UnitOfMeasure);
                    DBDataGrid.DataSource = dataContext.UnitOfMeasure.Local.ToBindingList();
                    break;
                case SetupType.Sales:
                    dataContext.SalesOrders.Load();
                    entityType = typeof(SalesOrders);
                    DBDataGrid.DataSource = dataContext.SalesOrders.Local.ToBindingList();
                    break;
                case SetupType.Integration:
                    break;
                case SetupType.Planning:
                    dataContext.PlanningSetup.Load();
                    entityType = typeof(PlanningSetup);
                    DBDataGrid.DataSource = dataContext.PlanningSetup.Local.ToBindingList();
                    break;
                case SetupType.Forecast:
                    dataContext.ForecastSetup.Load();
                    entityType = typeof(ForecastSetup);
                    DBDataGrid.DataSource = dataContext.ForecastSetup.Local.ToBindingList();
                    break;
            }
        }

        private void DBDataGrid_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            try
            {
                dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DBDataGrid_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DBDataGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DBDataGrid.EndEdit();
                dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void DBDataList_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                DBDataGrid.EndEdit();
                dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void DBDataGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (entityType == typeof(UnitOfMeasure))
            {
                UnitOfMeasureCard card = new UnitOfMeasureCard(DBDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString(), this);
                card.Show();
            }
            else if (entityType == typeof(VendorLocation))
            {
                VendorLocationSetupCard card = new VendorLocationSetupCard(DBDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString(), this);
                card.Show();
            }
            else if (entityType == typeof(VendorSetup))
            {
                VendorSetupCard card = new VendorSetupCard(DBDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString(), this);
                card.Show();
            }
            else if (entityType == typeof(VariantSetup))
            {
                VariantSetupCard card = new VariantSetupCard(DBDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString(), DBDataGrid.Rows[e.RowIndex].Cells[1].Value.ToString(), this);
                card.Show();
            }
            else if (entityType == typeof(LocationSetup))
            {
                LocationSetupCard card = new LocationSetupCard(DBDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString(), this);
                card.Show();
            }
            else if (entityType == typeof(CustomerSetup))
            {
                CustomerSetupCard card = new CustomerSetupCard(DBDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString(), this);
                card.Show();
            }
            else if (entityType == typeof(CustomerLocation))
            {
                CustomerLocationCard card = new CustomerLocationCard(DBDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString(), this);
                card.Show();
            }
            else if (entityType == typeof(BOMSetup))
            {
                BOMSetupCard card = new BOMSetupCard(DBDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString(), this);
                card.Show();
            }
            else if (entityType == typeof(ItemSetup))
            {
                ItemSetupCard card = new ItemSetupCard(DBDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString(), this);
                card.Show();
            }
            else if (entityType == typeof(UserSetup))
            {
                UserSetupCard card = new UserSetupCard(DBDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString(), this);
                card.Show();
            }
            else if (entityType == typeof(GeneralSetup))
            {
                GeneralSetupCard card = new GeneralSetupCard(int.Parse(DBDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString()), this);
                card.Show();
            }
            else if (entityType == typeof(PlanningSetup))
            {
                PlanningSetupCard card = new PlanningSetupCard(int.Parse(DBDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString()), this);
                card.Show();
            }
            else if (entityType == typeof(SalesOrders))
            {
                SalesOrdersCard card = new SalesOrdersCard(DBDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString(), this);
                card.Show();
            }
            else if (entityType == typeof(ForecastSetup))
            {
                ForecastSetupCard card = new ForecastSetupCard(DBDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString(), this);
                card.Show();
            }
        }

        public override void Refresh()
        {
            base.Refresh();
            dataContext = new dbContext();
            if (entityType == typeof(UnitOfMeasure))
            {
                dataContext.UnitOfMeasure.Load();
                DBDataGrid.DataSource = dataContext.UnitOfMeasure.Local.ToBindingList();
            }
            else if (entityType == typeof(VendorLocation))
            {
                dataContext.VendorLocation.Load();
                DBDataGrid.DataSource = dataContext.VendorLocation.Local.ToBindingList();
            }
            else if (entityType == typeof(VendorSetup))
            {
                dataContext.VendorSetup.Load();
                DBDataGrid.DataSource = dataContext.VendorSetup.Local.ToBindingList();
            }
            else if (entityType == typeof(VariantSetup))
            {
                dataContext.VariantSetup.Load();
                DBDataGrid.DataSource = dataContext.VariantSetup.Local.ToBindingList();
            }
            else if (entityType == typeof(LocationSetup))
            {
                dataContext.LocationSetup.Load();
                DBDataGrid.DataSource = dataContext.LocationSetup.Local.ToBindingList();
            }
            else if (entityType == typeof(CustomerSetup))
            {
                dataContext.CustomerSetup.Load();
                DBDataGrid.DataSource = dataContext.CustomerSetup.Local.ToBindingList();
            }
            else if (entityType == typeof(CustomerLocation))
            {
                dataContext.CustomerLocation.Load();
                DBDataGrid.DataSource = dataContext.CustomerLocation.Local.ToBindingList();
            }
            else if (entityType == typeof(BOMSetup))
            {
                dataContext.BOMSetup.Load();
                DBDataGrid.DataSource = dataContext.BOMSetup.Local.ToBindingList();
            }
            else if (entityType == typeof(ItemSetup))
            {
                dataContext.ItemSetup.Load();
                DBDataGrid.DataSource = dataContext.ItemSetup.Local.ToBindingList();
            }
            else if (entityType == typeof(UserSetup))
            {
                dataContext.UserSetup.Load();
                DBDataGrid.DataSource = dataContext.UserSetup.Local.ToBindingList();
            }
            else if (entityType == typeof(GeneralSetup))
            {
                dataContext.GeneralSetup.Load();
                DBDataGrid.DataSource = dataContext.GeneralSetup.Local.ToBindingList();
            }
            else if (entityType == typeof(PlanningSetup))
            {
                dataContext.PlanningSetup.Load();
                DBDataGrid.DataSource = dataContext.PlanningSetup.Local.ToBindingList();
            }
            else if (entityType == typeof(ForecastSetup))
            {
                dataContext.ForecastSetup.Load();
                DBDataGrid.DataSource = dataContext.ForecastSetup.Local.ToBindingList();
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (entityType == typeof(UnitOfMeasure))
            {
                UnitOfMeasureCard unitOfMeasureCard = new UnitOfMeasureCard(this, true);
                unitOfMeasureCard.Show();
            }
            else if (entityType == typeof(VendorLocation))
            {
                VendorLocationSetupCard vendorLocationSetupCard = new VendorLocationSetupCard(this, true);
                vendorLocationSetupCard.Show();
            }
            else if (entityType == typeof(VendorSetup))
            {
                VendorSetupCard vendorSetupCard = new VendorSetupCard(this, true);
                vendorSetupCard.Show();
            }
            else if (entityType == typeof(VariantSetup))
            {
                VariantSetupCard variantSetupCard = new VariantSetupCard(this, true);
                variantSetupCard.Show();
            }
            else if (entityType == typeof(LocationSetup))
            {
                LocationSetupCard locationSetupCard = new LocationSetupCard(this, true);
                locationSetupCard.Show();
            }
            else if (entityType == typeof(CustomerSetup))
            {
                CustomerSetupCard customerSetupCard = new CustomerSetupCard(this, true);
                customerSetupCard.Show();
            }
            else if (entityType == typeof(CustomerLocation))
            {
                CustomerLocationCard customerLocationCard = new CustomerLocationCard(this, true);
                customerLocationCard.Show();
            }
            else if (entityType == typeof(BOMSetup))
            {
                BOMSetupCard bomSetupCard = new BOMSetupCard(this, true);
                bomSetupCard.Show();
            }
            else if (entityType == typeof(ItemSetup))
            {
                ItemSetupCard itemSetupCard = new ItemSetupCard(this, true);
                itemSetupCard.Show();
            }
            else if (entityType == typeof(UserSetup))
            {
                UserSetupCard userSetupCard = new UserSetupCard(this, true);
                userSetupCard.Show();
            }
            else if (entityType == typeof(GeneralSetup))
            {
                GeneralSetupCard generalSetupCard = new GeneralSetupCard(this, true);
                generalSetupCard.Show();
            }
            else if (entityType == typeof(PlanningSetup))
            {
                PlanningSetupCard planningSetupCard = new PlanningSetupCard(this, true);
                planningSetupCard.Show();
            }
            else if (entityType == typeof(ForecastSetup))
            {
                ForecastSetupCard forecastSetupCard = new ForecastSetupCard(this, true);
                forecastSetupCard.Show();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }

    public enum SetupType
    {
        User,
        General,
        Item,
        Variant,
        BOM,
        Customer,
        CustomerLocation,
        Vendor,
        VendorLocation,
        Location,
        UnitOfMeasure,
        Sales,
        Integration,
        Planning,
        Forecast
    }
}
