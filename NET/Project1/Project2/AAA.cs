using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Project2
{
    partial class AAA
    {
        public void Method1()
        {
            WriteLine("Method1()");
        }

        public void Method2()
        {
            WriteLine("Method2()");
        }
        
    }
    partial class AAA
    {
        public void Method3()
        {
            WriteLine("Method3()");
        }
        public void Method4()
        {
            WriteLine("Method4()");
        }
    }
}
