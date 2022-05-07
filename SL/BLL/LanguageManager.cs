using SL.BLL.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.BLL
{
    internal static class LanguageManager
    {
        public static string Translate(string word, string language)
        {
            try
            {
                return DAL.LanguageDAL.Translate(word, language);
            }
            catch (WordNotFoundException ex)
            {
                DAL.LanguageDAL.Add(word, String.Empty, language);
                throw;
            }
        }
    }
}
