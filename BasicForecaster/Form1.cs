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

        private void ForecastButton_Click(object sender, EventArgs e)
        {
            //Forecast forecastForm = new Forecast();
            //forecastForm.Show();
            ForecastGraphic form = new ForecastGraphic();
            form.Show();
        }

        private void SetupButton_Click(object sender, EventArgs e)
        {
            SetupMenu setupMenu = new SetupMenu();
            setupMenu.Show();
        }

        private void HistoryButton_Click(object sender, EventArgs e)
        {
            HistoryMenu historyMenu = new HistoryMenu();
            historyMenu.Show();
        }

        private void ProcessButton_Click(object sender, EventArgs e)
        {
            TestForm f = new TestForm();
            f.Show();
        }
    }
}
