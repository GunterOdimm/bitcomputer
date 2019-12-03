using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Project2
{
    class Main02
    {
        static void main(String[] args)
        {
            Parent parent = new Parent("배지밀");
            parent.ParentMethod();
            WriteLine();

            Child child = new Child("배주현");
            child.ParentMethod();
            child.ChildMethod();
            WriteLine();

            Child child2 = new Child();
            child2.ParentMethod();
            child2.ChildMethod();
            WriteLine();

        }
    }
}
