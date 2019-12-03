using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Project2
{
    class ConsoleLogger : ILogger
    {
        public void WriteLog(String message)
        {
            WriteLine("{0}{1}", DateTime.Now.ToLocalTime(), message);
        }
    }
}
