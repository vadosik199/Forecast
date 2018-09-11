using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicForecaster.ForecastMethods.Method;

namespace BasicForecaster {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new SalesHistoryList();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e) {

            var form = new Forecast();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e) {

            var form = new SettingsForm();
            form.Show();
        }
    }
}
