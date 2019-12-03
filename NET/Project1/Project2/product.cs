using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Project2
{  // main01을 사용합니다.
    class product
    {
        private int price = 100;
        public ref int GetPrice()
        {
            return ref price;
        }
        public void PrintPrice()
        {
            WriteLine($"Price : {price}");
        }
    }
}
