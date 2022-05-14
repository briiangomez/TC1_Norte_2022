using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics.Tracing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.DAL
{

    public sealed class LoggerRepository
    {
        private readonly static LoggerRepository _instance = new LoggerRepository();

        public static LoggerRepository Current
        {
            get
            {
                return _instance;
            }
        }

        private LoggerRepository()
        {
            //Implent here the initialization of your singleton
        }


        private static string pathLog = ConfigurationManager.AppSettings["PathLog"];
        private static string logNameFile = ConfigurationManager.AppSettings["LogNameFile"];

        public void WriteLog(string message, EventLevel level, string user)
        {
            string fileName = pathLog + DateTime.Now.ToString("yyyyMMdd") + logNameFile;

            ///Aplicar una politica de logger 
            ///en funcion del Level (Error, Warning, Info, etc)
            ///

            using (StreamWriter stream = new StreamWriter(fileName, true))
            {
                string logMessage = String.Format("Date: {0} - Level: {1} - " +
                    "User: {2} - Message: {3}", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
                    , level.ToString(), user, message);
                stream.WriteLine(logMessage);
            }
        }
    }

}
