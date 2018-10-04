using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicForecaster.ForecastEngine.Models
{
    public sealed class Result
    {
        private List<Point> forecast;
        private List<double> timeSeries;

        public List<double> TimeSeries { get
            {
                return timeSeries;
            }
        }
        public List<Point> Forecast
        {
            get
            {
                return forecast;
            }
        }

        public Result(IEnumerable<Point> forecast, IEnumerable<double> timeSeries)
        {
            this.forecast = forecast.ToList();
            this.timeSeries = timeSeries.ToList();
        }

        public IEnumerator<Point> GetEnumerator()
        {
            foreach(Point p in forecast)
            {
                yield return p;
            }
        }

        public IEnumerable<double> GetTimeSeries()
        {
            foreach(double point in timeSeries)
            {
                yield return point;
            }
        }
    }
}
