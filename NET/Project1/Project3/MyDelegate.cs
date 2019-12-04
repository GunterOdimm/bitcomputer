using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    delegate int MyDelegate(int a, int b);
    // 직역은 대리자 라는 뜻이다.
    
    class Calulator
    {
        public int Plus(int a, int b)
        {
            return a + b;
        }
        public int Minus(int a , int b)
        {
            return a - b;
        }
    }
 
 }
