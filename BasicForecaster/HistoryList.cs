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
    public partial class HistoryList : Form
    {
        private dbContext dataContext = null;
        private Type entityType;

        public HistoryList()
        {
            InitializeComponent();
            dataContext = dbContext.GetInstance();
        }

        public HistoryList(HistoryType historyType)
            :this()
        {
            switch (historyType)
            {
                case HistoryType.Sales:
                    dataContext.Sales_Histories.Load();
                    entityType = typeof(Sales_History);
                    historyDataGrid.DataSource = dataContext.Sales_Histories.Local.ToBindingList();
                    break;
                case HistoryType.CustomerItemPrice:
                    dataContext.CustomerItemPrice.Load();
                    entityType = typeof(CustomerItemPrice);
                    historyDataGrid.DataSource = dataContext.CustomerItemPrice.Local.ToBindingList();
                    break;
                case HistoryType.SalesPriceChange:
                    dataContext.SalesPriceChangeHistory.Load();
                    entityType = typeof(SalesPriceChangeHistory);
                    historyDataGrid.DataSource = dataContext.SalesPriceChangeHistory.Local.ToBindingList();
                    break;
                case HistoryType.POS:
                    dataContext.POSHistory.Load();
                    entityType = typeof(POSHistory);
                    historyDataGrid.DataSource = dataContext.POSHistory.Local.ToBindingList();
                    break;
                case HistoryType.SalesOrders:
                    dataContext.SalesOrders.Load();
                    entityType = typeof(SalesOrders);
                    historyDataGrid.DataSource = dataContext.SalesOrders.Local.ToBindingList();
                    break;
                case HistoryType.PurchaseOrders:
                    dataContext.PurchaseOrders.Load();
                    entityType = typeof(PurchaseOrders);
                    historyDataGrid.DataSource = dataContext.PurchaseOrders.Local.ToBindingList();
                    break;
                case HistoryType.AssemblyProductionOrders:
                    dataContext.AssemblyOrdersProductionOrders.Load();
                    entityType = typeof(AssemblyOrdersProductionOrders);
                    historyDataGrid.DataSource = dataContext.AssemblyOrdersProductionOrders.Local.ToBindingList();
                    break;
                case HistoryType.CustomerBuyingCalendar:
                    dataContext.CustomerBuyingCalendar.Load();
                    entityType = typeof(CustomerBuyingCalendar);
                    historyDataGrid.DataSource = dataContext.CustomerBuyingCalendar.Local.ToBindingList();
                    break;
            }
        }

        private void historyDataGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
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

        private void historyDataGrid_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
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

        private void historyDataGrid_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
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

        private void historyDataGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (entityType == typeof(SalesOrders))
            {
                SalesOrdersCard card = new SalesOrdersCard(historyDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString(), this);
                card.Show();
            }
            else if (entityType == typeof(PurchaseOrders))
            {
                PurchaseOrdersCard card = new PurchaseOrdersCard(historyDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString(), this);
                card.Show();
            }
            else if (entityType == typeof(SalesPriceChangeHistory))
            {
                SalesPriceChangeHistoryCard card = new SalesPriceChangeHistoryCard(historyDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString(), this);
                card.Show();
            }
            else if (entityType == typeof(POSHistory))
            {
                POSHistoryCard card = new POSHistoryCard(double.Parse(historyDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString()), this);
                card.Show();
            }
            else if (entityType == typeof(CustomerItemPrice))
            {
                CustomerItemPriceCard card = new CustomerItemPriceCard(historyDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString(), historyDataGrid.Rows[e.RowIndex].Cells[3].Value.ToString(), DateTime.Parse(historyDataGrid.Rows[e.RowIndex].Cells[6].Value.ToString()), this);
                card.Show();
            }
            else if (entityType == typeof(CustomerBuyingCalendar))
            {
                CustomerBuyingCalendarCard card = new CustomerBuyingCalendarCard(historyDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString(), this);
                card.Show();
            }
            else if (entityType == typeof(AssemblyOrdersProductionOrders))
            {
                AssemblyProductionOrdersCard card = new AssemblyProductionOrdersCard(historyDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString(), this);
                card.Show();
            }
            else if (entityType == typeof(Sales_History))
            {
                SalesHistoryCard card = new SalesHistoryCard(int.Parse(historyDataGrid.Rows[e.RowIndex].Cells[1].Value.ToString()), this);
                card.Show();
            }
        }

        public override void Refresh()
        {
            base.Refresh();
            dataContext = dbContext.GetInstance();
            if (entityType == typeof(SalesOrders))
            {
                dataContext.SalesOrders.Load();
                historyDataGrid.DataSource = dataContext.SalesOrders.Local.ToBindingList();
            }
            else if (entityType == typeof(PurchaseOrders))
            {
                dataContext.PurchaseOrders.Load();
                historyDataGrid.DataSource = dataContext.PurchaseOrders.Local.ToBindingList();
            }
            else if (entityType == typeof(SalesPriceChangeHistory))
            {
                dataContext.SalesPriceChangeHistory.Load();
                historyDataGrid.DataSource = dataContext.SalesPriceChangeHistory.Local.ToBindingList();
            }
            else if (entityType == typeof(POSHistory))
            {
                dataContext.POSHistory.Load();
                historyDataGrid.DataSource = dataContext.POSHistory.Local.ToBindingList();
            }
            else if (entityType == typeof(CustomerItemPrice))
            {
                dataContext.CustomerItemPrice.Load();
                historyDataGrid.DataSource = dataContext.CustomerItemPrice.Local.ToBindingList();
            }
            else if (entityType == typeof(CustomerBuyingCalendar))
            {
                dataContext.CustomerBuyingCalendar.Load();
                historyDataGrid.DataSource = dataContext.CustomerBuyingCalendar.Local.ToBindingList();
            }
            else if (entityType == typeof(AssemblyOrdersProductionOrders))
            {
                dataContext.AssemblyOrdersProductionOrders.Load();
                historyDataGrid.DataSource = dataContext.AssemblyOrdersProductionOrders.Local.ToBindingList();
            }
            else if (entityType == typeof(Sales_History))
            {
                dataContext.Sales_Histories.Load();
                historyDataGrid.DataSource = dataContext.Sales_Histories.Local.ToBindingList();
            }
        }
    }


    public enum HistoryType
    {
        Sales,
        CustomerItemPrice,
        SalesPriceChange,
        POS,
        SalesOrders,
        PurchaseOrders,
        AssemblyProductionOrders,
        CustomerBuyingCalendar
    }
}
