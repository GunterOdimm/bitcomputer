using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Project2
{
    class CallByReference
    {

        static void Swap(ref int a, ref int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }
        static void main(String[] args)
        {
            int x = 3;
            int y = 5;
            WriteLine($"x : {x}, y={y}");
            Swap(ref x, ref y);
            WriteLine($"x : {x}, y={y}");
        }
    }
}
