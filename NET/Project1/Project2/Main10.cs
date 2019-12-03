using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Project2
{
    class Main10
    {
        static void main(String[] args)
        {
            WriteLine("FileLogger Start");
            ClimateMontor monitor = new ClimateMontor(new FileLogger("D:/Gunterohdim/Document/test/Mylog.txt"));
            monitor.start();

            WriteLine("ConsoleLogger Start");
            ClimateMontor monitor2 = new ClimateMontor(new ConsoleLogger());
            monitor2.start();
        }
    }
}
