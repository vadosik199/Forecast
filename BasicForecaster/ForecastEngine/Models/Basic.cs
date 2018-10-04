using BasicForecaster.ForecastEngine.Interfaces;
using BasicForecaster.ForecastMethods;
using Microsoft.R.Host.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BasicForecaster.ForecastEngine.Models
{
    public abstract class Basic : IForecastMethod
    {
        public async virtual Task<Result> Calculate(Parameters parameters)
        {
            RSession session = RSession.GetInstance();
            session.StartHost();
            try
            {
                BasicParameters basicParameters = parameters as BasicParameters;
                if (basicParameters != null)
                {
                    RSessionOutput tempOutputTask = await session.Session.ExecuteAndOutputAsync("library(forecast)");
                    RSessionOutput resultOutput = await session.Session.ExecuteAndOutputAsync(basicParameters.TemplateToExecute);
                    if (resultOutput.Errors != "")
                    {
                        if (resultOutput.Errors.ToLower().IndexOf("warning") == -1)
                            throw new Exception(resultOutput.Errors);
                    }
                    DataFrame dataFrame = await session.Session.GetDataFrameAsync("print(data.forec)");
                    if (dataFrame == null || dataFrame.Data == null || dataFrame.Data.Count != 5)
                    {
                        throw new Exception("Error in dataFrame");
                    }
                    List<double> timeSeries = await session.Session.GetListAsync<double>("data.ts[1:length(data.ts)]");
                    List<Point> forecast = new List<Point>();
                    for(int i = 0; i < dataFrame.Data[0].Count; i++)
                    {
                        forecast.Add(new Point(Convert.ToDouble(dataFrame.Data[0][i]), 
                            Convert.ToDouble(dataFrame.Data[1][i]), 
                            Convert.ToDouble(dataFrame.Data[2][i]), 
                            Convert.ToDouble(dataFrame.Data[3][i]), 
                            Convert.ToDouble(dataFrame.Data[4][i])));
                    }
                    return new Result(forecast, timeSeries);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                session.StopHost();
            }
            return null;
        }

        public virtual string GetTemplate(Parameters parameters)
        {
            return $"library(forecast)";
        }
    }
}
