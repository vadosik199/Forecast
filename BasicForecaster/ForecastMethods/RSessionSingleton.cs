using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Common.Core;
using Microsoft.R.Host.Client;

namespace BasicForecaster.ForecastMethods {
    public class RSessionSingleton {
        public IRHostSession session;
        public Task sessionStartTask;
        private static RSessionSingleton instance;

        private RSessionSingleton() { 
            session = RHostSession.Create("Test");
            sessionStartTask = session.StartHostAsync(new RHostSessionCallback());
        }

        public static RSessionSingleton Instance {
            get {
                if (instance == null) {
                    instance = new RSessionSingleton();
                }
                return instance;
            }
        }
    }
}
