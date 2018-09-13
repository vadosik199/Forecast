using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicForecaster.ForecastMethods;
using BasicForecaster.ForecastMethods.Method;
using BasicForecaster.ForecastMethods.MethodInterface;
using BasicForecaster.Models;
using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.WinForms;
using Microsoft.R.Host.Client;
using LiveCharts.Geared;
using LiveCharts.Wpf.Charts.Base;
using BasicForecaster.Services;
using System.Windows.Media;

namespace BasicForecaster {
    public partial class Forecast : Form
    {
        public static List<IBasicMethod> availableMethods;
        public Forecast() {

            InitializeComponent();
            availableMethods = GetMethods();
            foreach (var method in availableMethods)
            {
                comboBox1.Items.Add(method.GetMethodName());
            }
            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
            }
        }

        public static List<IBasicMethod> GetMethods()
        {
            return new List<IBasicMethod>
            {
                new Arima(),
                new HoltWinters(),
                new Holt(),
                new Ets(),
                new StlEts(),
                new MovingAverage()
            };
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private async void button2_Click(object sender, EventArgs e) {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please, select fitting method to use!");
                return;
            }
            if (comboBox1.SelectedIndex > availableMethods.Count)
            {

                MessageBox.Show("Method currently not available!");
                return;
            }
            int days;
            var ok = int.TryParse(textBox1.Text, out days);
            int count;
            var ok2 = int.TryParse(textBox2.Text, out count);
            int period;
            var ok3 = int.TryParse(textBox3.Text, out period);
            if (!ok || !ok2 || days <= 0 || count <= 0 || (ok3 && period < 0))
            {
                MessageBox.Show("Invalid count!");
                return;
            }
            List<double> items = null;
            using (var db = new dbContext())
            {
                /*items = db.Sales_Histories
                    .OrderByDescending(u => u.Entry_No)
                    .Take(days)
                    .OrderBy(u => u.Entry_No)
                    .Select(x => (double)x.Sales_Quantity)
                    .ToList();*/
                items = db.Sales_Histories
                    .GroupBy(x => x.Invoice_Date)
                    .OrderByDescending(x => x.Key)
                    .Take(days)
                    .OrderBy(x => x.Key)
                    .Select(x => x.Select(o => (double)(o.Sales_Quantity)).ToList().Sum())
                    .ToList();
            }
            IBasicMethod method = availableMethods[comboBox1.SelectedIndex];
            //var data = new List<double>(new double[] { 200, 250, 300, 350, 140, 200, 555, 120 });
            if (!ok3)
                period = 0;
            FResult result = null;
            if (items.Count != days)
                textBox1.Text = items.Count.ToString();
            var filepath = Directory.GetCurrentDirectory() + "\\result.png";
            try
            {
                result = await method.Forecast(items, count, filepath, period, 1920, 1080);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Unknown error appeared while trying to forecast data "+ex.Message);
                return;
            }
            if (result.Data == null)
            {
                MessageBox.Show(result.Error);
            }
            else
            {
                pictureBox1.ImageLocation = filepath;
                dataGridView1.Columns.Clear();
                dataGridView1.Columns.Add("Value", "Value");
                dataGridView1.Rows.Clear();
                foreach (var item in result.Data)
                {
                    dataGridView1.Rows.Add(new object[] { item });
                }
                ChartService.RefreshForecastChart(testChart, result);
                testChart.Zoom = ZoomingOptions.Xy;
                testChart.LegendLocation = LegendLocation.Left;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void pictureBox1_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start(pictureBox1.ImageLocation);
        }
    }
}
