using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicForecaster.ForecastEngine.Models
{
    public sealed class Point
    {
        public double Forecast { get; private set; }
        public double Hi80 { get; private set; }
        public double Lo80 { get; private set; }
        public double Hi95 { get; private set; }
        public double Lo95 { get; private set; }

        public Point(double forecast, double l80, double h80, double l95, double h95)
        {
            Forecast = forecast;
            Hi80 = h80;
            Hi95 = h95;
            Lo80 = l80;
            Lo95 = l95;
        }
    }
}
