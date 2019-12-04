using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Project3
{
    class AbstractProperty
    {
        private static bool CheckPassed(int score)
        {
            if (score >= 60)
                return true;
            else
                return false;
        }
        static void main(String[] args)
        {
            String[] array1 = new string[3] {"C++","C#","Java" };
            foreach (String subject in array1)
                WriteLine($"{subject}");
            WriteLine();

            String[] array2 = new string[] { "C++", "C#", "Java" };
            foreach (String subject in array2)
                WriteLine($"{subject},");
            WriteLine();

            String[] array3 = { "C++", "C#", "Java" };
            foreach (String subject in array3)
                WriteLine($"{subject}");
            WriteLine();

            int[] scores = new int[] { 90, 75, 80, 94, 50 };
            foreach (int score in scores)
                Write($"{score},");
            WriteLine();

            Array.Sort(scores);
            foreach (int score in scores)
                Write($"{score},");
            WriteLine("");

            WriteLine("");

            WriteLine($"Number of dimensions : {scores.Rank}");

            WriteLine("Binary Search : 80 is at {0}", Array.BinarySearch<int>(scores,80));

            WriteLine("Linear Search : 94 is at {0}", Array.IndexOf(scores, 94));

            WriteLine("Everyone Passed ? : {0}", Array.TrueForAll<int>(scores, CheckPassed));

            WriteLine($"Old length of scores : {scores.GetLength(0)}");

            Array.Resize<int>(ref scores, 10);
            WriteLine($"New length of scores : {scores.Length}");

            foreach (int score in scores)
                Write($"{score},");
            WriteLine();
            WriteLine();

            Array.Clear(scores, 3, 7);
            foreach (int score in scores)
                Write($"{score},");
            WriteLine();
            WriteLine();

            int[,] testArr = new int[2, 3] { { 1, 2,3}, { 4, 5, 6 } };
            for(int i = 0; i< testArr.GetLength(0); i++)
            {
                for (int j = 0; j < testArr.GetLength(1); j++)
                    WriteLine($"[{i},{j}] : {testArr[i, j]}");
                WriteLine();
            }

            ArrayList list = new ArrayList();
            for(int i= 0; i<5; i++)
            {
                list.Add(i);
            }
            foreach(object obj in list)
            {
                Write($"{obj},");
            }
            WriteLine();
            WriteLine();

            list.RemoveAt(2);

            foreach (object obj in list)
            {
                Write($"{obj},");
            }
            WriteLine();
            WriteLine();

            list.Insert(2, 2);
            foreach (object obj in list)
            {
                Write($"{obj},");
            }
            WriteLine();
            WriteLine();

            list.Add("abc");
            list.Add("def");

            for (int i = 0; i < list.Count; i++)
                Write($"{list[i]},");
            WriteLine();
            WriteLine();

            Queue que = new Queue();
            que.Enqueue(1);
            que.Enqueue(6);
            que.Enqueue(3);
            que.Enqueue(4);
            que.Enqueue(5);

            while (que.Count > 0)
                Write(que.Dequeue());
            WriteLine();
            WriteLine();

            Hashtable hashtable = new Hashtable();

            hashtable["하나"] = "one";
            hashtable["둘"] = "two";
            hashtable["셋"] = "three";
            hashtable["넷"] = "four";
            hashtable["다섯"] = "five";

            WriteLine(hashtable["하나"]);
            WriteLine(hashtable["둘"]);
            WriteLine(hashtable["셋"]);
            WriteLine(hashtable["넷"]);
            WriteLine(hashtable["다섯"]);
        }
    }
}
