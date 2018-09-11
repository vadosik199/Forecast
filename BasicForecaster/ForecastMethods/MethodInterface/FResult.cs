using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicForecaster.ForecastMethods.MethodInterface {
    public class FResult {
        public double[] Data;
        public double[] Low80;
        public double[] Low95;
        public double[] High80;
        public double[] High95;
        public string Error;
    }
}
