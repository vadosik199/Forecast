using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicForecaster.ForecastMethods.MethodInterface;
using Microsoft.Common.Core;
//using RDotNet;
//using RDotNet.Internals;
using Microsoft.R.Host.Client;

namespace BasicForecaster.ForecastMethods.Method {
    public class Arima : IBasicMethod {
        
        public override string GetMethodName()
        {
            return "ARIMA";
        }

        public override async Task<FResult> Forecast(List<double> data, int lead, string savePlot, int frequency, int plotWidth, int plotHeight) {
            var returnData = new FResult();

            var template = $@"
                data <- ts(data, frequency = {frequency})     
                fit <- auto.arima(data)
                forec <- forecast(fit,h={lead})         
            ";

            returnData = await IBasicMethod.Forecast(returnData, data, template, savePlot, plotWidth, plotHeight);


            return returnData;
        }
    }
}

