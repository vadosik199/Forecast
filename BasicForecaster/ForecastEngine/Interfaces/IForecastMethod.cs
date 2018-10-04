using BasicForecaster.ForecastEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicForecaster.ForecastEngine.Interfaces
{
    public interface IForecastMethod
    {
        Task<Result> Calculate(Parameters parameters);
        string GetTemplate(Parameters parameters);
    }
}
