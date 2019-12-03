using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Project2
{
    class Main03
    {
        static void main(String[] args)
        {
            Mammal mammal = new Mammal();
            mammal.Nurse();
            WriteLine("-");

            mammal = new Dog();
            mammal.Nurse();
            // mammal.Bark();
            WriteLine("--");

            if(mammal is Dog )
            // mammal 이 Dog레퍼런스(가르키다)가 맞다면
            {
                Dog dog = (Dog)mammal;
                // 강제 형변환 방법.
                dog.Nurse();
                dog.Bark();
                WriteLine();
            }

            mammal = new Human();
            mammal.Nurse();
            WriteLine();

            Human human = mammal as Human;
            human?.Nurse();
            human?.Speak();
            
        }
    }
}
