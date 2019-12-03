using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Project2
{
    class Main12
        //PropertyExample
    {
        static void main(String[] args)
        {
            var a = new { Name = "홍길동", Age = 29 };
            WriteLine($"Name : {a.Name}, Age : {a.Age}");

            var b = new { Subject = "수학", Scores = new int[] { 90,85,80,75} };

            WriteLine($"Subject : {b.Subject}, Scores : ");
            foreach (var score in b.Scores)
                Console.Write($"{score}");

            WriteLine();
        }
    }
}
