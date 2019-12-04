using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Project3
{
    class FilterableException : Exception
    {
        public int ErrorNo
        {
            get; set;
        }

        class ExceptionFilterEx
        {
            static void main(String[] args)
            {
                WriteLine("Enter number between 0~10 : ");
                String input = ReadLine();
                try
                {
                    int num = int.Parse(input);
                    if(num < 0 || num > 10)
                        throw new FilterableException() { ErrorNo = num};
                    else
                        WriteLine($"Output : {num}");
                }
                catch(FilterableException e) when (e.ErrorNo < 0)
                {
                    WriteLine("음수는 허용 안됨.");
                }
                catch (FilterableException e) when (e.ErrorNo > 10)
                {
                    WriteLine("10보다 큰 수는 혀용 안됨.");
                }

            }
        }
    }
}
