using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Project3
{
    class JustOneDelegate
    {
        delegate int Calculate(int a, int b);
        static void main(String[] args)
        {
            Calculate calc;
            calc = delegate (int a, int b)
            {
                return a + b;
            };
            WriteLine("3 + 4 : {0}", calc(3, 4));
            // 이렇게 한번만 호출하고 관리안하는일의 메서드는 소위
            // 익명 메서드
        }
    }
}
