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
using BasicForecaster.Models;

namespace BasicForecaster {
    public partial class SalesHistoryList : Form
    {
        private bool ActionsReady = false;
        private dbContext db = null;

        public SalesHistoryList() {
            InitializeComponent();
        }
        
        private void SalesHistoryList_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the '_Amit_R_devDataSet1.Sales_History' table. You can move, or remove it, as needed.
            //this.sales_HistoryTableAdapter.Fill(this._Amit_R_devDataSet1.Sales_History);
            db = dbContext.GetInstance();
            db.Sales_Histories.Load();
            dataGridView1.DataSource = db.Sales_Histories.Local.ToBindingList();
            MessageBox.Show(": " + db.Sales_Histories.Local.Count);
            ActionsReady = true;
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
            /*var id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            var obj = (Sales_History) dataGridView1.Rows[0].DataBoundItem;


            // Update xd
            using (var db = new dbContext()) {
                var entity = db.Sales_Histories.Find(id);
                if (entity == null) {
                    return;
                }

                db.Entry(entity).CurrentValues.SetValues(obj);
                db.SaveChanges();
            }*/
            db.SaveChanges();
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e) {

            //if (ActionsReady) {
                //MessageBox.Show("New row created");
                db.SaveChanges();
            //}
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e) {
            //if (ActionsReady)
            //{
                //MessageBox.Show("Row deleted");
                db.SaveChanges();
            //}
        }
    }
}
