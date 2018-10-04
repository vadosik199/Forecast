using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicForecaster.ForecastEngine.Models
{
    public sealed class ForecastMethodAttribute : Attribute
    {
        public string Name { get; set; }

        public ForecastMethodAttribute(string name)
        {
            Name = name;
        }
    }
}
