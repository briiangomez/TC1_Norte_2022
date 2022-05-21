using SL.Services.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BussinessExceptions
{
    public class ClienteMayorDeEdadException : Exception
    {
        public ClienteMayorDeEdadException(): base("El Cliente no es Mayor de Edad".Translate())
        {
            base.HelpLink = "";
        }
    }
}
