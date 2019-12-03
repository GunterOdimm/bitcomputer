using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Project2
{
    class Child : Parent
    {   //main02
        public Child() // 따로 지정자가 없으니 부모의 기본자를 가지고 온다.
        {
            WriteLine($"{this.name}.Child()");
        }
        public Child(String name) : base(name)
        {
            WriteLine($"{this.name}.Child(String)");
        }
        ~Child()
        {
            WriteLine($"{this.name}.~Child()");
        }
        public void ChildMethod() 
        {
            WriteLine($"{this.name}.ChildMethod()");
        }
    }
}
