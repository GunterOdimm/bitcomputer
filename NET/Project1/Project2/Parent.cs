using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Project2
{
    class Parent
    {
        protected String name;
        public Parent()
        {
            name = "아이린";
            WriteLine($"{this.name}.Parent()");
        }

        public Parent(String name)
        {
            this.name = name;
            WriteLine($"{this.name}.Parent(String)");
        }
        ~Parent()
        {
            WriteLine($"{this.name}.~Parent()");
        }
        public void ParentMethod()
        {
            WriteLine($"{this.name}.ParenteMethod()");
        }
    }
}
