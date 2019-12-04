using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Project3
{
    class GenericClassEx
    {
        static void main(String[] args)
        {
            MyList<String> str_list = new MyList<string>();
            str_list[0] = "abc";
            str_list[1] = "def";
            str_list[2] = "ghi";
            str_list[3] = "jkl";
            str_list[4] = "mno";
            // 컴파일러가 직접 걸러내기 때문에 빠르다.
            for (int i = 0; i< str_list.Length; i++)
                WriteLine(str_list[i]);

            MyList<int> int_list = new MyList<int>();
            for (int i = 0; i < 5; i++)
                int_list[i] = i;

            for (int i = 0; i < str_list.Length; i++)
             WriteLine(str_list[i]);

            Dictionary<String, int> dic = new Dictionary<String, int>();
            dic["국어"] = 90;
            dic["영어"] = 85;
            dic["수학"] = 95;
            dic["물리"] = 100;
            dic["화학"] = 95;

            WriteLine(dic["물리"]);
            foreach (KeyValuePair<String, int> item in dic)
                WriteLine($"{item.Key} : {item.Value}");

            try
            {
                int? a = null;
                int b = a ?? throw new ArgumentNullException();
            }
            catch (ArgumentNullException e)
            {
                WriteLine(e);
            }
            try
            {
                int[] array = new[] { 1, 2, 3 };
                int index = 4;
                int value = array[index >= 0 && index < 3 ? index : throw new IndexOutOfRangeException()];
            }
            catch(IndexOutOfRangeException e)
            {
                WriteLine(e);
            }


        }
    }
}
