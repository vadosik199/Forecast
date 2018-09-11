using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicForecaster.ForecastMethods.MethodInterface;
using Microsoft.R.Host.Client;

namespace BasicForecaster.ForecastMethods.Method {
    public class StlEts : IBasicMethod {

        public override string GetMethodName()
        {
            return "STL+ETS";
        }

        public override async Task<FResult> Forecast(List<double> data, int lead, string savePlot, int frequency, int plotWidth, int plotHeight) {
            var returnData = new FResult();
            if (frequency <= 1) {
                returnData.Error = "Period should be higher than 1";
                return returnData;
            }

            var template = $@" 
                data <- ts(data, frequency = {frequency})
                fit <- stl(data, ""per"")
                forec <- forecast(fit,h={lead})    
            ";


            returnData = await IBasicMethod.Forecast(returnData, data, template, savePlot, plotWidth, plotHeight);

            
            return returnData;
        }
    }
}
