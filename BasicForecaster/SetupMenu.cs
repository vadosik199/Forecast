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
    public partial class SetupMenu : Form
    {
        public SetupMenu()
        {
            InitializeComponent();
        }

        private void ItemSetupButton_Click(object sender, EventArgs e)
        {
            DBDataList dBDataList = new DBDataList(SetupType.Item);
            dBDataList.Show();
            Close();
        }

        private void VariantSetupButton_Click(object sender, EventArgs e)
        {
            DBDataList dBDataList = new DBDataList(SetupType.Variant);
            dBDataList.Show();
            Close();
        }

        private void BOMSetupButton_Click(object sender, EventArgs e)
        {
            DBDataList dBDataList = new DBDataList(SetupType.BOM);
            dBDataList.Show();
            Close();
        }

        private void CustomerSetupButton_Click(object sender, EventArgs e)
        {
            DBDataList dBDataList = new DBDataList(SetupType.Customer);
            dBDataList.Show();
            Close();
        }

        private void CustomerLocationSetupButton_Click(object sender, EventArgs e)
        {
            DBDataList dBDataList = new DBDataList(SetupType.CustomerLocation);
            dBDataList.Show();
            Close();
        }

        private void VendorSetupButton_Click(object sender, EventArgs e)
        {
            DBDataList dBDataList = new DBDataList(SetupType.Vendor);
            dBDataList.Show();
            Close();
        }

        private void VendorLocationSetupButton_Click(object sender, EventArgs e)
        {
            DBDataList dBDataList = new DBDataList(SetupType.VendorLocation);
            dBDataList.Show();
            Close();
        }

        private void LocationSetupButton_Click(object sender, EventArgs e)
        {
            DBDataList dBDataList = new DBDataList(SetupType.Location);
            dBDataList.Show();
            Close();
        }

        private void UnitOfMeasureButton_Click(object sender, EventArgs e)
        {
            DBDataList dBDataList = new DBDataList(SetupType.UnitOfMeasure);
            dBDataList.Show();
            Close();
        }

        private void SalesSetupButton_Click(object sender, EventArgs e)
        {
        }

        private void UserSetupButton_Click(object sender, EventArgs e)
        {
            DBDataList dBDataList = new DBDataList(SetupType.User);
            dBDataList.Show();
            Close();
        }

        private void GeneralSetupButton_Click(object sender, EventArgs e)
        {
            DBDataList dBDataList = new DBDataList(SetupType.General);
            dBDataList.Show();
            Close();
        }

        private void PlanningSetupButton_Click(object sender, EventArgs e)
        {
            DBDataList dBDataList = new DBDataList(SetupType.Planning);
            dBDataList.Show();
            Close();
        }
    }
}
