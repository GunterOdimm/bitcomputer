using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Project2
{
    class PropertyExample
    {
        static void main(String[] args)
        {
            BirthdayInfo birth = new BirthdayInfo();
            //{ 
            //    Name = "아이린",
            //    Birthday = new DateTime(1991, 5, 10) 
            //}
            WriteLine($"Nmae : {birth.Name}");
            // get이 동작한다.
            WriteLine($"Birthday : {birth.Birthday.ToShortDateString()}");
            WriteLine($"Age : {birth.Age}");
        }
    }
}
