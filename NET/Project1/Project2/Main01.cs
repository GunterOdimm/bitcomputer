using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Project2
{
    class Main01
    {
        static void main(String[] args)
        {
            product carrot = new product();
            ref int ref_price = ref carrot.GetPrice();
            int normal_price = carrot.GetPrice();

            carrot.PrintPrice();
            WriteLine($"Ref Price : {ref_price}");
            WriteLine($"Normal Price : {normal_price}");

            ref_price = 200;
            carrot.PrintPrice();
            WriteLine($"Ref Price : {ref_price}");
            WriteLine($"Normal Price : {normal_price}");
        }
    }
}
