using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Project3
{
    delegate int Compare(int a, int b);
    
    class DelegateExample2
    {// 버블 소트 기본
        static int AscendCompare(int a, int b)
        {
            //버블 소트
            if (a > b)
                return 1;
            else if (a == b)
                return 0;
            else
                return -1;
        }
        

        static int DescendCompare(int a, int b)
        {
            if (a < b)
                return 1;
            else if (a == b)
                return 0;
            else
                return -1;
        }

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
        static void main(String[] args)
        {
            int[] array = { 3, 7, 4, 2, 9 };

            WriteLine("Ascending Sort!");
            BubbleSort(array, new Compare(AscendCompare));

            for (int i = 0; i < array.Length; i++)
                Write($"{array[i]} ");
            WriteLine();


            WriteLine("Descending Sort!");
            BubbleSort(array, new Compare(DescendCompare));

            for (int i = 0; i < array.Length; i++)
                Write($"{array[i]} ");
            WriteLine();
        }
    }
}
    