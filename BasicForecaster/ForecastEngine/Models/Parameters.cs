using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicForecaster.ForecastEngine.Models
{
    public abstract class Parameters
    {
        public List<double> Data { get; protected set; }
        public int Frequency { get; protected set; }
        public int Period { get; protected set; }

        public Parameters(IEnumerable<double> data, int frequency, int period)
        {
            Data = data.ToList();
            Frequency = frequency;
            Period = period;
        }
    }
}
