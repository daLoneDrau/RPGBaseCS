using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGBase
{
    public sealed class RPGEception : Exception
    {

        /** the developer message. */
        private readonly string developerMessage;
    }
}
