using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Project2
{
    class Main05
    {
        static void main(String[] args)
        {
            Configuration config = new Configuration();
            config.SetConfig("Version", "V5.0");
            config.SetConfig("Size","655,324 KB");

            WriteLine(config.GetConfig("Version"));
            WriteLine(config.GetConfig("Size"));

            config.SetConfig("Version", "V5.1");
            WriteLine(config.GetConfig("Version"));
        }
    }
}
