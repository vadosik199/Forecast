using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicForecaster
{
    public partial class HistoryMenu : Form
    {
        public HistoryMenu()
        {
            InitializeComponent();
        }

        private void SalesHistoryButton_Click(object sender, EventArgs e)
        {

        }

        private void CustomerItemPriceButton_Click(object sender, EventArgs e)
        {

        }

        private void SalesPriceChangeHistoryButton_Click(object sender, EventArgs e)
        {
            HistoryList historyList = new HistoryList(HistoryType.SalesPriceChange);
            historyList.Show();
            Close();
        }

        private void POSHistoryButton_Click(object sender, EventArgs e)
        {
            HistoryList historyList = new HistoryList(HistoryType.POS);
            historyList.Show();
            Close();
        }

        private void SalesOrdersButton_Click(object sender, EventArgs e)
        {
            HistoryList historyList = new HistoryList(HistoryType.SalesOrders);
            historyList.Show();
            Close();
        }

        private void PurchaseOrdersButton_Click(object sender, EventArgs e)
        {
            HistoryList historyList = new HistoryList(HistoryType.PurchaseOrders);
            historyList.Show();
            Close();
        }

        private void AssemblyOrdersProductionOrdersButton_Click(object sender, EventArgs e)
        {

        }

        private void CustomerBuyingCalendarButton_Click(object sender, EventArgs e)
        {

        }
    }
}
