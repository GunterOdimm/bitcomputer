using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Hello2
    {
        static void Main(String[] args)
        {
            StaticField.ShowCount();

            new ClassA();
            new ClassA();
            new ClassB();
            new ClassB();

            StaticField.ShowCount();
        }
    }
}
