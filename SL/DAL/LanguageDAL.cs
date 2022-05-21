using SL.BLL.Exceptions;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SL.DAL
{
    internal static class LanguageDAL
    {
        private static string pathBase = ConfigurationManager.AppSettings["PathDefaultLanguageName"];

        public static string Translate(string word)
        {
            string currentCulture = Thread.CurrentThread.CurrentUICulture.Name;

            using (StreamReader str = new StreamReader(pathBase + currentCulture))
            {
                while(!str.EndOfStream)
                {
                    string line = str.ReadLine();
                    string[] words = line.Split('=');

                    if(words[0] == word)
                    {
                        return words[1];
                    }
                }
                //La palabra no ha sido encontrada...
                throw new WordNotFoundException();
            }            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="word"></param>
        /// <param name="Idioma"></param>
        public static void Add(string word, string wordValue, string language)
        {
            //Agregar la clave con el valor en blanco...
        }

        public static List<string> GetLanguages()
        {
            return null;
        }

        public static Dictionary<string, string> GetAllLanguage(string language)
        {
            return null;
        }

    }
}
