using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Project3
{
    class sampleTest
    {
        static void BubbleSort(int[] dataSet, Compare Comparer)
        {
            int i = 0;
            int j = 0;
            int temp = 0;

            for (i = 0; i < dataSet.Length; i++)
            {
                for (j = 0; j < dataSet.Length - (i + 1); j++)
                {
                    if (Comparer(dataSet[j], dataSet[j + 1]) > 0)
                    {
                        temp = dataSet[j + 1];
                        dataSet[j + 1] = dataSet[j];
                        dataSet[j] = temp;
                    }
                }
            }
        }
        delegate int Calculate(int a, int b);

        static void main(String[] args)
        {
            int[] array = { 3, 7, 4, 2, 9 };

            Calculate Compare;
            BubbleSort(array, delegate(int a, int b)
            {
                if (a > b)
                    return 1;
                else if (a == b)
                    return 0;
                else
                    return -1;
            });
            for (int i = 0; i < array.Length; i++)
                Write($"{array[i]} ");
            WriteLine();

        }
    }
}
