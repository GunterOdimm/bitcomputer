using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Project1
{
    class StaticField
    {
        public static int count = 0;
        public static void ShowCount()
        {
            WriteLine($"StaticField.count : {count}");
        }
    }


}
