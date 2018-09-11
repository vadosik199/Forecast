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

            var session = RHostSession.Create(Guid.NewGuid().ToString());
            var sessionStartTask = session.StartHostAsync(new RHostSessionCallback());
            await sessionStartTask;
            await session.ExecuteAsync(template);
            var result = await session.ExecuteAndOutputAsync(customTemplate);
            if (result.Errors != "") {
                returnData.Error = result.Errors;
                if(result.Errors.ToLower().IndexOf("warning") == -1)
                    return returnData;
            }
            var resultDataFrame = await session.GetDataFrameAsync("print(forec)");
            if (resultDataFrame == null || resultDataFrame.Data == null || resultDataFrame.Data.Count != 5) {
                session?.StopHostAsync();
                returnData.Error = "Unknown error detected!";
                return returnData;
            }
            returnData.Data = resultDataFrame.Data[0].Select(x => (double)x).ToArray();
            returnData.Low80 = resultDataFrame.Data[1].Select(x => (double)x).ToArray();
            returnData.High80 = resultDataFrame.Data[2].Select(x => (double)x).ToArray();
            returnData.Low95 = resultDataFrame.Data[3].Select(x => (double)x).ToArray();
            returnData.High95 = resultDataFrame.Data[4].Select(x => (double)x).ToArray();

            if (plotName != "") {
                var dataImg = await session.PlotAsync("forec", plotWidth, plotHeight, 72);
                Bitmap bmp;
                using (var ms = new MemoryStream(dataImg)) {
                    bmp = new Bitmap(ms);
                }
                bmp.Save(plotName);
            }
            session?.StopHostAsync();
            return returnData;
        }
    }
}
