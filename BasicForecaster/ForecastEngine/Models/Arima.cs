using BasicForecaster.ForecastEngine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicForecaster.ForecastEngine.Models
{
    [ForecastMethod("Arima")]
    public sealed class Arima : Basic
    {
        public async override Task<Result> Calculate(Parameters parameters)
        {
            try
            {
                ArimaParameters arimaParameters = parameters as ArimaParameters;
                if (arimaParameters != null)
                {
                    Result result = await base.Calculate(new BasicParameters(arimaParameters, GetTemplate(arimaParameters)));
                    foreach(var a in result)
                    {

                    }
                    return result;
                }
            }
            catch
            {

            }
            return null;
        }

        public override string GetTemplate(Parameters parameters)
        {
            ArimaParameters arimaParameters = parameters as ArimaParameters;
            if (arimaParameters != null)
            {

                return $"" +
                    $"data.data <- c({string.Join(", ", arimaParameters.Data)})" + Environment.NewLine +
                    $"data.ts <- ts(data.data {(arimaParameters.Frequency <= 0 ? "" : $",frequency = {arimaParameters.Frequency}")})" + Environment.NewLine +
                    $"data.fit <- auto.arima(data.ts)" + Environment.NewLine +
                    $"data.forec <- forecast(data.fit {(arimaParameters.Period <= 0 ? "" : $",h = {arimaParameters.Period}")})";
            }
            else
            {
                throw new Exception("This parameters does not containg Arima settings");
            }
        }
    }
}
