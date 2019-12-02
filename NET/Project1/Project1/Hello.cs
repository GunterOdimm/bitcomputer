using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Hello
    {
        static void main(String[] args)
        {
            car myCar = new car();
            car yourCar = new car("SUV", "블랙");

            myCar.ShowStatus();
            yourCar.ShowStatus();
        }
    }
}
