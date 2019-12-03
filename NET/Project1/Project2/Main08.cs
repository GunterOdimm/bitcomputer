using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Project2
{
    class Main08
    {
        static void main(String[] args)
        {
            var a = ("아이린", 29);
            WriteLine($"{a.Item1},{a.Item2}");
            var b = (Name :"배주현", Age : 29);
            WriteLine($"{b.Name},{b.Age}");

            var (name, age) = b;
            WriteLine($"{name},{age}");

            b = a;
            WriteLine($"{b.Name},{b.Age}");
        }
    }
}
