using System;
using System.Collections.Generic;
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
    public class Holt : IBasicMethod {

        public override string GetMethodName()
        {
            return "HOLT";
        }

        public override async Task<FResult> Forecast(List<double> data, int lead, string savePlot, int frequency, int plotWidth, int plotHeight) {
            var returnData = new FResult();

            var template = $@"
                data <- ts(data, frequency = {frequency})
                forec <- holt(data,h={lead})
            ";

            returnData = await IBasicMethod.Forecast(returnData, data, template, savePlot, plotWidth, plotHeight);


            return returnData;
        }
    }
}
