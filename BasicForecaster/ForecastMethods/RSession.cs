using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.R.Host.Client;

namespace BasicForecaster.ForecastMethods
{
    public class RSession
    { 
        private static RSession instance;
        public IRHostSession Session { get; private set; }
        private RSession(string sessionName)
        {
            Session = RHostSession.Create(sessionName);
        }

        /// <summary>
        /// Get RSession instance
        /// </summary>
        /// <param name="sessionName">Set session name</param>
        /// <returns>Return RSession instance</returns>
        public static RSession GetInstance(string sessionName = "Test")
        {
            if (instance == null)
                instance = new RSession(sessionName);
            return instance;
        }

        /// <summary>
        /// Start R host process
        /// </summary>
        public void StartHost()
        {
            Task sessionStartTask = Session.StartHostAsync(new RHostSessionCallback());
            sessionStartTask.Wait();
        }

        /// <summary>
        /// Stop R host process
        /// </summary>
        public void StopHost()
        {
            Task sessionStopTask = Session.StopHostAsync();
            sessionStopTask.Wait();
        }

        /// <summary>
        /// Used to save image, produced by R
        /// </summary>
        /// <param name="fileName">Specify image name</param>
        /// <param name="width">Image width</param>
        /// <param name="height">Image height</param>
        /// <param name="dpi">Dots per inch</param>
        public static async Task<bool> SavePlotImage(IRHostSession session, string fileName, int width, int height, int dpi)
        {
            byte[] dataImgArray = await session.PlotAsync("forec", width, height, dpi);
            Bitmap dataImgFile;
            using (MemoryStream memoryStream = new MemoryStream(dataImgArray))
            {
                dataImgFile = new Bitmap(memoryStream);
            }
            dataImgFile.Save(fileName);
            return true;
        }
    }
}
