using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Project1
{
    class ThisConstructor
    {
        private int a, b, c;
        public ThisConstructor()
        {
            a = 1111;
            WriteLine("ThisConstructor()");
        }
        public ThisConstructor(int b) : this()
        {
            this.b = b;
            WriteLine("ThisConstructor(int)");
        }
        public ThisConstructor(int b, int c) : this(b)
        {
            this.c = c;
            WriteLine("ThisConstructor(int, int)");
        }
        public void printFields()
        {
            WriteLine($"a : {a}, b : {b}, c : {c}");
        }
    }
}
