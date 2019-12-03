using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    public static class EngancedInteger
    {// 확장 메서드
        public static int Square(this int input)
        {
            return input * input;
        }

        public static String Myprint(this int input)
        {
            return "<======" + input + "======>";
        }

        public static int Power(this int input ,int exponent)
        {
            int result = input;
            for(int i =1; i < exponent; i++)
            {
                result *= input;
            }
            return result;
        }
    }
}
