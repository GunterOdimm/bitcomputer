using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Project2
{
    class Main14
    {
        static void Main(String[] args)
        {
            NamedValue name = new NamedValue() { Name = "이름", Value = "아이린" };
            NamedValue height = new NamedValue() { Name = "키", Value = "158CM" };
            NamedValue weight = new NamedValue() { Name = "몸무게", Value = "40kg" };
            WriteLine($"{ name.Name} : {name.Value}");
            WriteLine($"{ height.Name} : {height.Value}");
            WriteLine($"{ weight.Name} : {weight.Value}");
        }
    }
}
