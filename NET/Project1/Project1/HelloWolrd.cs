using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Project1
{
    class HelloWolrd

    {

        static String ToLowerString(String str)
        {
            var arr = str.ToCharArray();
            for(int i=0; i<arr.Length; i++)
            {
                arr[i] = ToLowerChar(i);
            }
            char ToLowerChar(int i)
            {
                if (arr[i] < 65 || arr[i] > 90)
                    return arr[i];
                else
                    return (char)(arr[i] + 32);
            }
            return new string(arr);
        }

        static void PrintProfile(String name, String phone)
        {
            WriteLine($"Name: {name}, Phone: {phone}");
        }

        static void Divide(int a1, int b1, out int quotient, out int remainder)
        {
            quotient = a1 / b1;
            remainder = a1 % b1;

        }

        static int Sum(params int[] args)
        {
            int sum = 0;
            for(int i = 0; i< args.Length; i++)
            {
                if (i > 0)
                    Write(", ");
                Write(args[i]);
                sum += args[i];
            }
            WriteLine();
            return sum;
        }
        enum ColorCode { RED, BLUE, GREEN, ORANGE }
        static void Main(String[] args)
        {
            WriteLine("Hello World!");

            sbyte a = -10;
            byte b = 40;

            WriteLine("---------------");

            WriteLine($"a={a}, b={b}");

            short c = -30_000;
            ushort d = 60_000;

            WriteLine($"c={c}, d={d}");

            WriteLine("---------------");

            int e = -10_000_000;
            uint f = 300_000_000;

            WriteLine($"e={e}, f={f}");

            long g = -500_000_000_000;
            ulong h = 2_000_000_000_000_000_000;

            WriteLine($"a={g}, h={h}");

            byte i = 0b1111_0000;
            WriteLine($"i={i}");
            byte j = 0xF0;
            WriteLine($"j={j}");
            uint k = 0x1234_abcd;
            WriteLine("k={" + k + "}");


            WriteLine("---------------");

            float l = 3.1415_9265_4685_7892_3547_6548_1257_13f;
            double m = 3.1415_9265_4685_7892_3547_6548_1257_13;
            decimal n = 3.1415_9265_4685_7892_3547_6548_1257_13m;

            WriteLine(l);
            WriteLine(m);
            WriteLine(n);

            object z = 123;
            object w = 3.1415965m;
            object x = true;
            object y = "문자열";

            WriteLine(z);
            WriteLine(w);
            WriteLine(x);
            WriteLine(y);


            WriteLine("---------------");

            int aa = 123;
            string bb = aa.ToString();
            WriteLine(bb);
            float cc = 12.3f;
            bb = cc.ToString();
            WriteLine(bb);
            String ee = "2636";
            int dd = int.Parse(ee);
            WriteLine(dd);

            String gg = "1.2585";
            float hh = float.Parse(gg);
            WriteLine(hh);

            WriteLine("---------------");


            WriteLine((int)ColorCode.RED);
            WriteLine((int)ColorCode.BLUE);
            WriteLine(ColorCode.GREEN);
            WriteLine(ColorCode.ORANGE);

            WriteLine("---------------");
            /*  C#에서는 null값을 할당할수있다.
            *   hasValue는 변수값이 null인지 아닌지를 확인한다.
            *   이때 변수의 값이 null이면 False를 return해준다.
            */
            int? xx = null;

            WriteLine(xx.HasValue);
            WriteLine(xx != null);

            xx = 3;
            WriteLine(xx.HasValue);
            WriteLine(xx != null);
            WriteLine(xx.Value);
            WriteLine("---------------");

            var zz = 20;
            WriteLine("Type : {0}, Value : {1}", zz.GetType(), zz);

            var uu = 3.145685;
            WriteLine("Type : {0}, Value : {1}", uu.GetType(), uu);

            var ww = "Hello World";
            WriteLine("Type : {0}, Value : {1}", ww.GetType(), ww);

            var yy = new int[] { 10, 20, 30 };
            Write("Type : {0}, Value : ", yy.GetType());
            foreach (var nn in yy)
                Write("{0} ", nn);
            WriteLine();

            WriteLine("---------------");

            string str = "This is string search sample";
            WriteLine(str);
            WriteLine();

            WriteLine("Index of 'search' : {0}", str.IndexOf("search"));
            WriteLine("index of 'h' : {0}", str.IndexOf('h'));

            WriteLine("StartWith 'This' : {0}", str.IndexOf("This"));
            WriteLine("index of 'string' : {0}", str.IndexOf("string"));

            WriteLine("EndWith 'This' : {0}", str.IndexOf("This"));
            WriteLine("EndWith 'sample' : {0}", str.IndexOf("sample"));

            WriteLine("Contains 'search' : {0}", str.Contains("search"));
            WriteLine("Contains 'school' : {0}", str.Contains("school"));

            WriteLine("---------------");
            String str2 = "Welcome to the C# world!";

            WriteLine(str2.Substring(15, 2));
            WriteLine(str2.Substring(8));
            WriteLine();

            String[] arr = str2.Split(new String[] { " " }, StringSplitOptions.None);
            WriteLine("Word count : {0}", arr.Length);

            foreach (String element in arr)
                WriteLine("{0}", element);
            WriteLine("---------------");
            // Taking a string 
            String str3 = "Geeks, For Geeks";

            String[] spearator = { "s, ", "For" };
            Int32 count = 2;

            // using the method 
            String[] strlist = str3.Split(spearator, count,
                   StringSplitOptions.RemoveEmptyEntries);

            foreach (String s in strlist)
            {
                Console.WriteLine(s);
            }
            WriteLine("---------------");
            String fmt = "{0,-10}{1,-5}{2,20}";


            WriteLine(fmt, "Type", "size", "Explain");
            WriteLine(fmt, "byte", "1", "byte타입");
            WriteLine(fmt, "short", "2", "short타입");
            WriteLine(fmt, "int", "4", "int타입");
            WriteLine(fmt, "long", "8", "long타입");
            WriteLine(fmt, "byte", "1", "byte타입");
            WriteLine("---------------");

            WriteLine("10진수 : {0:D}", 123);
            WriteLine("10진수 : {0:D5}", 123);

            WriteLine("16진수 : 0x{0:X}", 0xFF1234);
            WriteLine("16진수 : 0x{0:X8}", 0xFF1234);

            WriteLine("숫자 : {0:N}", 123456);
            WriteLine("숫자 : {0:N0}", 123456);

            WriteLine("고정소수점 : {0:F}", 123.456);
            WriteLine("고정소수점 : {0:F5}", 123.456);

            WriteLine("10진수 : {0:E}", 123.456789);
            WriteLine("---------------");

            String name = "아이린";
            int age = 29;
            WriteLine($"{name,-10},{age:D3}"); 
            
            name = "배주현";
            age = 29;
            WriteLine($"{name},{age:-10:D3}");
            WriteLine($"{age:0}");
            WriteLine($"{age:10}");
            WriteLine($"{age:4}");
            WriteLine($"{age:3}");
            WriteLine($"{age:2}");
            WriteLine($"{age:1}");
            WriteLine($"{age:0}");
            WriteLine($"{age:-1}");
            WriteLine($"{age:-2}");
            WriteLine($"{age:-3}");
            WriteLine($"{age:-4}");
            WriteLine($"{age:-5}");
            WriteLine($"{age:-6}");
            WriteLine($"{age:-7}");
            WriteLine($"{age:-8}");
            WriteLine($"{age:-9}");
            WriteLine($"{age:-10}");
            WriteLine($"{age:-11}");
            WriteLine($"{age:-12}");
            WriteLine($"{age:-13}");
            WriteLine($"{age:-14}");
            WriteLine($"{age:-15}");
            WriteLine($"{age:-16}");

            name = "배토끼";
            age = 29;
            WriteLine($"{name},{(age >  20 ? "성인" : "미성년자.")}");
            WriteLine("---------------");

            ArrayList av = null;
            av?.Add("C++");
            av?.Add("C#");
            WriteLine($"Count : {av?.Count}");
            WriteLine($"{av?[0]}");
            WriteLine($"{av?[1]}");

            av = new ArrayList();
            WriteLine(av);
            av?.Add("C++");
            av?.Add("C#");
            WriteLine($"Count : {av?.Count}");
            WriteLine($"{av?[0]}");
            WriteLine($"{av?[1]}");
            WriteLine("---------------");

            int? num = null;
            WriteLine($"{num ?? 0}");
            num = 10;
            WriteLine($"{num ?? 0}");
            String str4 = null;
            WriteLine($"{str4 ?? "Default"}");
            str4 = "I Study C#";
            WriteLine($"{str4 ?? "Default"}");


            WriteLine("---------------");

            int a1 = 20;
            int b1 = 3;
            //int c1;
            //int d1;

            Divide(a1, b1, out int c1, out int d1);

            WriteLine($"a:{a1}, b:{b1},a/b:{c1},a%b{d1}");

            WriteLine("---------------");

            int sum = Sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            WriteLine($"Sum : {sum}");

            WriteLine("---------------");

            PrintProfile(name: "이순신", phone: "010-1111-2222");
            PrintProfile(phone: "010-1111-5555", name: "아이린");
            PrintProfile("배주현", "010-8576-2222");
            PrintProfile("배토끼", phone: "010-1111-6207");

            WriteLine("---------------");

            WriteLine(ToLowerString("Hello"));
            WriteLine(ToLowerString("World"));
            WriteLine(ToLowerString("C# Programming"));

            WriteLine("---------------");



            WriteLine("---------------");
        }
    }
}
