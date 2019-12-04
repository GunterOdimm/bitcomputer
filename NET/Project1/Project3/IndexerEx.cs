using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Project3
{
    class IndexerEx
    {
        static void main(String[] args)
        {
            MyList list = new MyList();
            // 인덱서 : 내 자신을 배열처럼 사용할수 있게 해주는것이다
            for (int i = 0; i < 5; i++)
                list[i] = i;
            for(int i=0; i < list.Length; i++)
            {
                WriteLine(list[i]);
            }
        }
    }
}
