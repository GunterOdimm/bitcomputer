using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Project1
{
    class Hello3
    {
        static void Main(String[] args)
        {
            WriteLine("Shallow Copy");
            ShallowDeepCopy source = new ShallowDeepCopy();
            source.Field1 = 10; 
            source.Field2 = 20;

            ShallowDeepCopy target = source;
            target.Field2 = 30;
            WriteLine($"{source.Field1}{source.Field2}");
            WriteLine($"{target.Field1}{target.Field2}");

            WriteLine("Deep Copy");
            ShallowDeepCopy deepSource = new ShallowDeepCopy();
            deepSource.Field1 = 10;
            deepSource.Field2 = 20;

            ShallowDeepCopy deepTarget = deepSource.DeepCopy();
            deepTarget.Field2 = 30;
            WriteLine($"{deepSource.Field1}{deepSource.Field2}");
            WriteLine($"{deepTarget.Field1}{deepTarget.Field2}");

        }

  
    }
}
