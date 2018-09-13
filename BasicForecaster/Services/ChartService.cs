using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.WinForms;
using System.Windows.Media;
using BasicForecaster.ForecastMethods.MethodInterface;

namespace BasicForecaster.Services
{
    /// <summary>
    /// Simplify work with LiveChart library and Forecasting methods
    /// </summary>
    public static class ChartService
    {
        /// <summary>
        /// Update data in specified chart controll
        /// </summary>
        /// <param name="chart">Chart, which need to update</param>
        /// <param name="data">New data</param>
        public static void RefreshForecastChart(LiveCharts.WinForms.CartesianChart chart, FResult data)
        {
            Dictionary<string, List<double>> lines = new Dictionary<string, List<double>>
            {
                { "Forecast points", Enumerable.Repeat(double.NaN, data.TimeSeriesPoints.Count).ToList() },
                { "Lo 80", Enumerable.Repeat(double.NaN, data.TimeSeriesPoints.Count).ToList() },
                { "Hi 80", Enumerable.Repeat(double.NaN, data.TimeSeriesPoints.Count).ToList() },
                { "Lo 95", Enumerable.Repeat(double.NaN, data.TimeSeriesPoints.Count).ToList() },
                { "Hi 95", Enumerable.Repeat(double.NaN, data.TimeSeriesPoints.Count).ToList() },
                { "Time Series", data.TimeSeriesPoints }
            };
            int count = 0;
            for (int i = 0; i < data.ResultDataFrame.Data[0].Count; i++)
            {
                for (int j = 0; j < data.ResultDataFrame.Data.Count; j++)
                {
                    if (count == 0)
                    {
                        lines["Forecast points"].Add(Convert.ToDouble(data.ResultDataFrame.Data[j][i]));
                    }
                    else if (count == 1)
                    {
                        lines["Lo 80"].Add(Convert.ToDouble(data.ResultDataFrame.Data[j][i]));
                    }
                    else if (count == 2)
                    {
                        lines["Hi 80"].Add(Convert.ToDouble(data.ResultDataFrame.Data[j][i]));
                    }
                    else if (count == 3)
                    {
                        lines["Lo 95"].Add(Convert.ToDouble(data.ResultDataFrame.Data[j][i]));
                    }
                    else if (count == 4)
                    {
                        lines["Hi 95"].Add(Convert.ToDouble(data.ResultDataFrame.Data[j][i]));
                    }
                    count++;
                    if (count == 5)
                        count = 0;
                }
            }
            List<SeriesOption> lineOptions = lines.Select((line) => new SeriesOption { Title = line.Key, Values = line.Value }).ToList();
            lineOptions.Where(line => line.Title.Equals("Forecast points"))
                .ToList()
                .ForEach(line => {
                    line.IsDashed = true;
                    line.PointGeometry = DefaultGeometries.Diamond;
                });
            lineOptions.Where(line => line.Title.Equals("Time Series"))
                .ToList()
                .ForEach(line =>
                {
                    line.LineColor = Brushes.Black;
                });
            chart.Series = CreateSeriesCollection(lineOptions);
        }

        /// <summary>
        /// Create SeriesCollection due to options
        /// </summary>
        /// <param name="seriesOptions">List, which contain options for Series collection</param>
        /// <returns></returns>
        public static SeriesCollection CreateSeriesCollection(List<SeriesOption> seriesOptions)
        {
            SeriesCollection series = new SeriesCollection();
            foreach(SeriesOption lineOption in seriesOptions)
            {
                LineSeries lineSeries = new LineSeries();
                if (!string.IsNullOrEmpty(lineOption.Title))
                {
                    lineSeries.Title = lineOption.Title;
                }
                else
                {
                    lineSeries.Title = $"Series {series.Count + 1}";
                }
                if (lineOption.Values != null)
                {
                    lineSeries.Values = new ChartValues<double>(lineOption.Values);
                }
                lineSeries.PointGeometry = lineOption.PointGeometry;
                if (lineOption.PointFillColor != null)
                {
                    lineSeries.Fill = lineOption.PointFillColor;
                }
                else
                {
                    lineSeries.Fill = Brushes.Transparent;
                }
                if (lineOption.IsDashed)
                {
                    lineSeries.StrokeDashArray = new DoubleCollection { 2 };
                }
                if (lineOption.LineColor != null)
                {
                    lineSeries.Stroke = lineOption.LineColor;
                }
                series.Add(lineSeries);
            }
            return series;
        }
    }

    /// <summary>
    /// Class, that represent LineSeries setting
    /// </summary>
    public class SeriesOption
    {
        public string Title { get; set; } = "Series";
        public List<double> Values { get; set; }
        public Geometry PointGeometry { get; set; }
        public Brush PointFillColor { get; set; }
        public bool IsDashed { get; set; }
        public Brush LineColor { get; set; }
    }
}
