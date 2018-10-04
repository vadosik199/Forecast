using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicForecaster.ForecastEngine.Models
{
    [ForecastMethod("Ets")]
    public sealed class Ets : Basic
    {
        public async override Task<Result> Calculate(Parameters parameters)
        {
            try
            {
                EtsParameters etsParameters = parameters as EtsParameters;
                if (etsParameters != null)
                {
                    Result result = await base.Calculate(new BasicParameters(etsParameters, GetTemplate(etsParameters)));
                    foreach (var a in result)
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
            EtsParameters etsParameters = parameters as EtsParameters;
            if (etsParameters != null)
            {
                return $"" +
                    $"data.data <- c({string.Join(", ", etsParameters.Data)})" + Environment.NewLine +
                    $"data.ts <- ts(data.data {(etsParameters.Frequency <= 0 ? "" : $",frequency = {etsParameters.Frequency}")})" + Environment.NewLine +
                    $"data.fit <- ets(data.ts)" + Environment.NewLine +
                    $"data.forec <- forecast(data.fit {(etsParameters.Period <= 0 ? "" : $",h = {etsParameters.Period}")})";
            }
            else
            {
                throw new Exception("This parameters does not containg Ets settings");
            }
        }
    }
}
