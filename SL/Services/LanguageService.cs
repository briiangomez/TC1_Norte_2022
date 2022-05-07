using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Services
{
    internal static class LanguageService
    {
        public static string Translate(string word, string language)
        {
            return BLL.LanguageManager.Translate(word, language);
        }
    }
}
