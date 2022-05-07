using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Services.Extensions
{
    public static class StringExtension
    {
        public static string Translate(this string word, string language)
        {
            return BLL.LanguageManager.Translate(word, language);
        }
    }
}
