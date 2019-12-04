using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Project3
{
    class UserDefinedException
    {
        static uint MergeARGB(uint alpha, uint red, uint green, uint blue)
        {
            uint[] args = new uint[] { alpha, red, green, blue };

            foreach (uint arg in args)
            {
                if (arg > 255)
                    throw new InvalidArgumenException()
                    {
                        Argument = arg,
                        Range = "0~255"
                    };
                
            }
            return (alpha << 24 & 0xFF000000) | (red << 16 & 0x00FF0000) | (green << 8 & 0xFF00) | (blue & 0xff);
        }
        static void main(String[] args)
        {
            try
            {
                WriteLine("0x{0:x8}", MergeARGB(255, 100, 100, 100));
                WriteLine("0x{0:x8}", MergeARGB(1, 165, 190, 125));
                WriteLine("0x{0:x8}", MergeARGB(0, 255, 255, 260));
            }
            catch (InvalidArgumenException e)
            {
                WriteLine(e.Message);
                WriteLine($"Argument : {e.Argument}, Range : {e.Range}");
            }
        }
    }
}
