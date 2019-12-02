using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Project1
{
    class Hello4
    {
        static void Main(String[] args)
        {
            Employee worker = new Employee();
            worker.SetName("아이린");
            worker.SetPosition("RedVelvet");
            WriteLine($"{worker.GetName()} {worker.GetPosition()}");
        }
    }
}
