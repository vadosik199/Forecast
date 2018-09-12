using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.R.Host.Client;

namespace BasicForecaster.ForecastMethods.MethodInterface {
    public abstract class IBasicMethod
    {
        public abstract string GetMethodName();

        public abstract Task<FResult> Forecast(List<double> data, int lead, string savePlot, int frequency, int plotWidth,
            int plotHeight);

        public static async Task<FResult> Forecast(FResult parent, List<double> data, string customTemplate, string plotName, int plotWidth, int plotHeight)
        {
            var returnData = new FResult();

            plotName = plotName.Replace(@"\", @"\\");

            var template = $@"
                suppressMessages(library(forecast))
                data <- c({string.Join(",", data)})
            ";
            RSession rInstance = RSession.GetInstance();
            rInstance.StartHost();
            await rInstance.Session.ExecuteAsync(template);
            var result = await rInstance.Session.ExecuteAndOutputAsync(customTemplate);
            if (result.Errors != "") {
                returnData.Error = result.Errors;
                if(result.Errors.ToLower().IndexOf("warning") == -1)
                    return returnData;
            }
            var resultDataFrame = await rInstance.Session.GetDataFrameAsync("print(forec)");
            if (resultDataFrame == null || resultDataFrame.Data == null || resultDataFrame.Data.Count != 5) {
                rInstance.StopHost();
                returnData.Error = "Unknown error detected!";
                return returnData;
            }
            returnData.Data = resultDataFrame.Data[0].Select(x => (double)x).ToArray();
            returnData.Low80 = resultDataFrame.Data[1].Select(x => (double)x).ToArray();
            returnData.High80 = resultDataFrame.Data[2].Select(x => (double)x).ToArray();
            returnData.Low95 = resultDataFrame.Data[3].Select(x => (double)x).ToArray();
            returnData.High95 = resultDataFrame.Data[4].Select(x => (double)x).ToArray();

            if (plotName != "") {
                await RSession.SavePlotImage(rInstance.Session, plotName, plotWidth, plotHeight, 72);
            }
            rInstance.StopHost();
            return returnData;
        }
    }
}
