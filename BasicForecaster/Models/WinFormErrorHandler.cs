using BasicForecaster.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BasicForecaster.Models
{
    class WinFormErrorHandler : IErrorHandler
    {
        public void Handle(Exception e)
        {
            MessageBox.Show(e.Message);
        }
    }
}
