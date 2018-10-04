using BasicForecaster.ForecastEngine.Interfaces;
using BasicForecaster.ForecastEngine.Models;
using BasicForecaster.Models;
using BasicForecaster.Services;
using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Point = BasicForecaster.ForecastEngine.Models.Point;

namespace BasicForecaster
{
    public partial class ForecastGraphic : Form
    {
        public ForecastGraphic()
        {
            InitializeComponent();
            InitializeComboBox();
        }

        private async void methodComboBox_Leave(object sender, EventArgs e)
        {
            if (methodComboBox.SelectedIndex != -1)
            {
                using (dbContext db = new dbContext())
                {
                    List<double> data = db.Sales_Histories
                    .GroupBy(x => x.Invoice_Date)
                    .OrderByDescending(x => x.Key)
                    .Take(50)
                    .OrderBy(x => x.Key)
                    .Select(x => x.Select(o => (double)o.Sales_Quantity).ToList().Sum())
                    .ToList();
                    /*List<double> dataForec = db.Sales_Histories
                    .GroupBy(x => x.Invoice_Date)
                    .OrderByDescending(x => x.Key)
                    .Take(15)
                    .OrderBy(x => x.Key)
                    .Select(x => x.Select(o => (double)o.Sales_Quantity).ToList().Sum())
                    .Take(10)
                    .ToList();*/
                    Basic method = GetMethodByAttributeValue(methodComboBox.SelectedItem.ToString());
                    if (method != null)
                    {
                        Parameters parameters = null;
                        //Parameters forForec = null;
                        if (method.GetType() == typeof(Arima))
                        {
                            parameters = new ArimaParameters(data, 4, 5);
                            //forForec = new ArimaParameters(dataForec, 4, 10);
                        }
                        else if (method.GetType() == typeof(Ets))
                        {
                            parameters = new EtsParameters(data, 4, 5);
                        }
                        Result result = await method.Calculate(parameters);

                        //Result forec = await method.Calculate(forForec);
                        forecastingDataGrid.Columns.Clear();
                        forecastingDataGrid.Columns.Add("timeSeriesColumn", "Time Series");
                        forecastingDataGrid.Columns.Add("forecastingColumn", "Forecasting");
                        foreach (double val in result.GetTimeSeries())
                        {
                            forecastingDataGrid.Rows.Add(new object[] { val, "" });
                        }
                        foreach (Point p in result)
                        {
                            forecastingDataGrid.Rows.Add(new object[] { "", p.Forecast });
                        }
                        #region Chart
                        Dictionary<string, List<double>> lines = new Dictionary<string, List<double>>
                        {
                            { "Time Series", result.TimeSeries },
                            { "Forecast points", Enumerable.Repeat(double.NaN, result.TimeSeries.Count).ToList() }
                        };
                        lines["Forecast points"] = lines["Forecast points"].Concat(result.Forecast.Select(f => f.Forecast).ToList()).ToList();

                        List<SeriesOption> lineOptions = lines.Select((line) => new SeriesOption { Title = line.Key, Values = line.Value }).ToList();
                        lineOptions.Where(line => line.Title.Equals("Forecast points"))
                            .ToList()
                            .ForEach(line => {
                                line.IsDashed = true;
                                line.PointGeometry = DefaultGeometries.Diamond;
                                //line.LineColor = System.Windows.Media.Brushes.Sienna;
                            });
                        lineOptions.Where(line => line.Title.Equals("Time Series"))
                            .ToList()
                            .ForEach(line =>
                            {
                                //line.LineColor = System.Windows.Media.Brushes.;
                            });
                        forecastingChart.Series = ChartService.CreateSeriesCollection(lineOptions);

                        forecastingChart.Zoom = ZoomingOptions.Xy;
                        forecastingChart.LegendLocation = LegendLocation.Left;
                        #endregion
                    }
                }
            }
        }

        private void InitializeComboBox()
        {
            IEnumerable<string> methods = typeof(Basic)
                .Assembly
                .GetTypes()
                .Where(t => t.IsSubclassOf(typeof(Basic)) && !t.IsAbstract)
                .Select(t => (Attribute.GetCustomAttribute(t, typeof(ForecastMethodAttribute)) as ForecastMethodAttribute).Name);
            foreach(string methodName in methods)
            {
                methodComboBox.Items.Add(methodName);
            }
        }

        private Basic GetMethodByAttributeValue(string forecastAttributeName)
        {
            Basic method = typeof(Basic)
                .Assembly
                .GetTypes()
                .Where(t => t.IsSubclassOf(typeof(Basic)) && !t.IsAbstract && (Attribute.GetCustomAttribute(t, typeof(ForecastMethodAttribute)) as ForecastMethodAttribute).Name.Equals(forecastAttributeName))
                .Select(t => (Basic)Activator.CreateInstance(t)).FirstOrDefault();
            return method;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void locationFilterTextBox_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(locationFilterTextBox.Text))
            {
                using (dbContext db = new dbContext())
                {
                }
            }
        }

        private async void itemNoTextBox_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(itemNoTextBox.Text))
            {
                using (dbContext db = new dbContext())
                {
                }
            }
        }
    }
}
