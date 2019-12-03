using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Project2
{
    class GasolineCar : Car
    {
        public GasolineCar(String model, String powerTrain) : base(model, powerTrain)
        { }
        public new void drive()
        {
            WriteLine($"{model}{powerTrain} 부르릉~~");
        }

    }
}
