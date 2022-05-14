using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Configuration;
using SL.Services;
using System.Diagnostics.Tracing;

namespace SL.BLL
{
    internal static class ExceptionBLL
    {
        private static string DALAssembly = ConfigurationManager.AppSettings["DALAssembly"];
        private static string BLLAssembly = ConfigurationManager.AppSettings["BLLAssembly"];
        private static string UIAssembly = ConfigurationManager.AppSettings["UIAssembly"];

        public static void Handle(Exception ex, object sender)
        {
            ///Aplica la politica de excepciones

            string assemblyName = sender.GetType().Module.Name;

            if(assemblyName == DALAssembly)
            {
                //Aplicar la politica para Excepciones de la DAL
                DALPolicy(ex);
            }
            else if (assemblyName == BLLAssembly)
            {
                //Aplicar la politica para Excepciones de la BLL
                BLLPolicy(ex);
            }
            else if (assemblyName == UIAssembly)
            {
                //Aplicar la politica para Excepciones de la UI
                UIPolicy(ex);
            }
        }


        public static void DALPolicy(Exception ex)
        {
            // 1 - Registro la info de la excepcion (Bitacora)
            LoggerService.WriteLog(ex.Message, EventLevel.Error, "brian");
            //2 - Propagacion
            throw ex;
        }


        public static void BLLPolicy(Exception ex)
        {
            //Excepcion
            if(ex.InnerException != null)
            {
                //Exception viene de la DAL
                //Propagacion
                throw new Exception("Ocurrio un error accediendo a la BD", ex);
            }
            else
            {
                // 1 - Registro la info de la excepcion (Bitacora)
                LoggerService.WriteLog(ex.Message, EventLevel.Error, "brian");
                //2 - Propagacion
                throw ex;
            }
        }

        public static void UIPolicy(Exception ex)
        {
            // 1 - Registro la info de la excepcion (Bitacora)

            //2 - Propagacion
            throw new Exception(String.Empty, ex);
        }

    }
}
