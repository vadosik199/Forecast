﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicForecaster.Interfaces
{
    public interface IErrorHandler
    {
        void Handle(Exception e);
    }
}
