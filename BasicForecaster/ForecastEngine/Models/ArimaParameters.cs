using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicForecaster.ForecastEngine.Models
{
    public sealed class ArimaParameters : Parameters
    {
        public ArimaParameters(IEnumerable<double> data, int frequency, int period)
            :base(data, frequency, period)
        {
        }
    }
}
