
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Project3
{
    class EnumeratorEx
    {
        static void main(String[] args)
        {
            var obj = new MyEnumerator();
            
            foreach (int i in obj)
                WriteLine(i);
        }
    }
}
