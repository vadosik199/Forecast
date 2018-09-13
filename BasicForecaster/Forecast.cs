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
                items = db.Sales_Histories
                    .OrderByDescending(u => u.Entry_No)
                    .Take(days)
                    .OrderBy(u => u.Entry_No)
                    .Select(x => (double)x.Sales_Quantity)
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
                //MessageBox.Show("Ok");

                /*Test chart*/
                List<double> pointList = new List<double>();
                List<double> bottomLine = Enumerable.Repeat(double.NaN, result.TimeSeriesPoints.Count).ToList();
                List<double> topLine = Enumerable.Repeat(double.NaN, result.TimeSeriesPoints.Count).ToList();
                List<double> bBottomLine = Enumerable.Repeat(double.NaN, result.TimeSeriesPoints.Count).ToList();
                List<double> tTopLine = Enumerable.Repeat(double.NaN, result.TimeSeriesPoints.Count).ToList();
                int k = 0;
                for (int i = 0; i < result.ResultDataFrame.Data[0].Count; i++)
                {
                    for(int j = 0; j < result.ResultDataFrame.Data.Count; j++)
                    {
                        pointList.Add((double)result.ResultDataFrame.Data[j][i]);
                        if (k == 1)
                        {
                            bottomLine.Add((double)result.ResultDataFrame.Data[j][i]);
                        }
                        else if (k == 2)
                        {
                            topLine.Add((double)result.ResultDataFrame.Data[j][i]);
                        }
                        else if (k == 3)
                        {
                            bBottomLine.Add((double)result.ResultDataFrame.Data[j][i]);
                        }
                        else if (k == 4)
                        {
                            tTopLine.Add((double)result.ResultDataFrame.Data[j][i]);
                        }
                        k++;
                        if (k == 5)
                            k = 0;
                    }
                }
                testChart.Series = new SeriesCollection();
                testChart.Series.Add(new LineSeries
                {
                    Title = "Forecast points",
                    Values = new ChartValues<double>(Enumerable.Repeat(double.NaN, result.TimeSeriesPoints.Count).ToList().Concat(pointList.Where((x, i) => i % 5 == 0))),
                    PointGeometry = DefaultGeometries.Diamond,
                    Fill = System.Windows.Media.Brushes.Transparent,
                    StrokeDashArray = new System.Windows.Media.DoubleCollection { 2 }
                });
                testChart.Series.Add(new LineSeries
                {
                    Title = "Lo 80",
                    Values = new ChartValues<double>(bottomLine),
                    Fill = System.Windows.Media.Brushes.Transparent,
                    PointGeometry = null
                });
                testChart.Series.Add(new LineSeries
                {
                    Title = "Hi 80",
                    Values = new ChartValues<double>(topLine),
                    Fill = System.Windows.Media.Brushes.Transparent,
                    PointGeometry = null
                });
                testChart.Series.Add(new LineSeries
                {
                    Title = "Lo 95",
                    Values = new ChartValues<double>(bBottomLine),
                    Fill = System.Windows.Media.Brushes.Transparent,
                    PointGeometry = null
                });
                testChart.Series.Add(new LineSeries
                {
                    Title = "Hi 95",
                    Values = new ChartValues<double>(tTopLine),
                    Fill = System.Windows.Media.Brushes.Transparent,
                    PointGeometry = null
                });
                testChart.Series.Add(new LineSeries
                {
                    Title = "Time Series",
                    Values = new ChartValues<double>(result.TimeSeriesPoints),
                    Fill = System.Windows.Media.Brushes.Transparent,
                    PointGeometry = null
                });
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
