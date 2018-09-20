using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicForecaster.ForecastMethods.MethodInterface;
using BasicForecaster.Models;

namespace BasicForecaster.ForecastMethods.Method {
    public class Settings {

        static Forecast_Setup GetForecastSetup() {
            using (var db = dbContext.GetInstance())
            {
                return db.Forecast_Setups.First();
            }
        }
        static Forecast_Method GetForecastMethodSetup(IBasicMethod method) {
            using (var db = dbContext.GetInstance())
            {
                var setup = db.Forecast_Methods.First(x => x.Code == method.GetMethodName());
                if (setup == null)
                {
                    setup = new Forecast_Method();
                    setup.Code = method.GetMethodName();
                    db.Forecast_Methods.Add(setup);
                    db.SaveChanges();
                }
                return setup;
            }
        }

        /*public static void SavePlotToFile(REngine engine, string forecastVarName, string fileName)
        { 
            Console.WriteLine($"png(filename=\"" + fileName + "\", width=2560, height=1440)");
            engine.Evaluate($"png(filename=\""+fileName+"\", width=1920, height=1080)");
            Console.WriteLine($"plot({forecastVarName})");
            engine.Evaluate($"plot({forecastVarName})");
            Console.WriteLine($"dev.off()");
            engine.Evaluate($"dev.off()");
        }*/
    }
}
