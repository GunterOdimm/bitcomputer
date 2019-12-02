using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Project1
{
    class Hello5
    {
        static void Main(String[] args)
        {
            ThisConstructor a = new ThisConstructor();
            a.printFields();
            WriteLine();

            ThisConstructor b = new ThisConstructor(10);
            b.printFields();
            WriteLine();

            ThisConstructor c = new ThisConstructor(10,20);
            c.printFields();
            WriteLine();
        }
    }
}
