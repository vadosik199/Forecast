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
                    break;
                case SetupType.General:
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
                DBDataGrid.EndEdit();
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
            if (entityType == typeof(UnitOfMeasure))
            {
                UnitOfMeasureCard card = new UnitOfMeasureCard(DBDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                card.Show();
            }
            else if (entityType == typeof(VendorLocation))
            {
                VendorLocationSetupCard card = new VendorLocationSetupCard(DBDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                card.Show();
            }
            else if (entityType == typeof(VendorSetup))
            {
                VendorSetupCard card = new VendorSetupCard(DBDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                card.Show();
            }
            else if (entityType == typeof(VariantSetup))
            {
                VariantSetupCard card = new VariantSetupCard(DBDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString(), DBDataGrid.Rows[e.RowIndex].Cells[1].Value.ToString());
                card.Show();
            }
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
        Integration
    }
}
