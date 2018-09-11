using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicForecaster.ForecastMethods.MethodInterface;
using Microsoft.R.Host.Client;

namespace BasicForecaster.ForecastMethods.Method {
    public class Ets : IBasicMethod {

        public override string GetMethodName()
        {
            return "ETS";
        }

        public override async Task<FResult> Forecast(List<double> data, int lead, string savePlot, int frequency, int plotWidth, int plotHeight) {
            var returnData = new FResult();

            var template = $@"
                data <- ts(data, frequency = {frequency})
                fit <- ets(data)
                forec <- forecast(fit,h={lead})
            ";

            returnData = await IBasicMethod.Forecast(returnData, data, template, savePlot, plotWidth, plotHeight);


            return returnData;
        }
    }
}
