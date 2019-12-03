using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Project2
{
    class Car
    {
        protected String model;
        protected String powerTrain;

        public Car(String model, String powerTrain)
        {
            this.model = model;
            this.powerTrain = powerTrain;
        }

        //public virtual void drive()
        public void drive()
        {
            WriteLine("달린다~~~~");
        }
    }
}
