using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using BasicForecaster.ForecastMethods.Method;
using BasicForecaster.ForecastMethods.MethodInterface;
using BasicForecaster.Models;

namespace WebDisplay.Controllers
{
    public class ForecastController : Controller {

        public static List<IBasicMethod> methods = new List<IBasicMethod>
            {
                new Arima(),
                new HoltWinters(),
                new Holt(),
                new Ets(),
                new StlEts(),
                new MovingAverage()
            };
        

        public ForecastController()
        {
        }

        // GET: Forecast
        public ActionResult Index()
        {
            ViewBag.Methods = methods;
            return View();
        }

        public class ForecastingRequest
        {
            public int From { get; set; }
            public int To { get; set; }
            public int Count { get; set; }
            public int Periodicity { get; set; }
            public string Method { get; set; }
            public int ImageWidth { get; set; }
            public int ImageHeight { get; set; }
        }

        public class ForecastingResult
        {
            public string Image { get; set; }
            public double[] ForecastData { get; set; }
            public double[] Low80Data { get; set; }
            public double[] High80Data { get; set; }
            public double[] Low95Data { get; set; }
            public double[] High95Data { get; set; }
            public string Error { get; set; }
        }
        

        [HttpGet]
        public async Task<ActionResult> Result(ForecastingRequest request)
        {
            ForecastingResult dataResult = new ForecastingResult();
            List<double> items = null;
            using (var db = new dbContext()) {
                items = db.Sales_Histories.Where(x => x.Entry_No >= request.From && x.Entry_No <= request.To).OrderBy(x => x.Entry_No).Select(x => (double)x.Sales_Quantity).ToList();
            }
            IBasicMethod method = null;
            foreach (var cMethod in methods)
            {
                if (cMethod.GetMethodName() == request.Method)
                {
                    method = cMethod;
                }
            }
            if (method == null) {
                dataResult.Error = "Couldn't found method that you need!";
                return View(dataResult);
            }
            FResult result = null;
            var imageName = Guid.NewGuid().ToString();
            var dir = Server.MapPath("/Images");
            var imageFileName = Path.Combine(dir, imageName + ".png");
            dataResult.Image = imageName;
            try {
                result = await method.Forecast(items, request.Count, imageFileName, request.Periodicity, request.ImageWidth, request.ImageHeight);
            } catch (Exception ex) {
                dataResult.Error = "Unknown error appeared while trying to forecast data";
                return View(dataResult);
            }
            if (result.Data != null) {
                dataResult.ForecastData = result.Data;
                dataResult.Low80Data = result.Low80;
                dataResult.High80Data = result.High80;
                dataResult.Low95Data = result.Low95;
                dataResult.High95Data = result.High95;
                dataResult.Error = "";
            }
            else
            {
                dataResult.Error = result.Error;
            }
            return View(dataResult);
        }

        public ActionResult Image(string id) {
            var dir = Server.MapPath("/Images");
            var path = Path.Combine(dir, id + ".png");
            return base.File(path, "image/png");
        }
    }
}