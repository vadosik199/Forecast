using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicForecaster.ForecastEngine.Models
{
    public sealed class BasicParameters : Parameters
    {
        public string TemplateToExecute { get; protected set; }
        public BasicParameters(Parameters parameters, string template)
            :base(parameters.Data, parameters.Frequency, parameters.Period)
        {
            TemplateToExecute = template;
        }
    }
}
