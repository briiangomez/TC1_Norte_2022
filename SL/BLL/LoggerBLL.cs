using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics.Tracing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.BLL
{
    internal static class LoggerBLL
    {
        public static void WriteLog(string message, EventLevel level, string user)
        {
            SL.DAL.LoggerRepository.Current.WriteLog(message, level, user);
        }
    }

}
