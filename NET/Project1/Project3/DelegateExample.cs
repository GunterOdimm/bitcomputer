using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Project3
{
    class DelegateExample
    {
        static void main(String[] args)
        {
            Calulator cal = new Calulator();
            MyDelegate Callback;
            // 델리게이트 객체를 ref처럼 생성해주었다.(cal)처럼
            // 이처럼 메서드를 대신 호출해주기에 대리자 라고 한다.
            Callback = new MyDelegate(cal.Plus);
            WriteLine(Callback(3, 4));
            Callback = new MyDelegate(cal.Plus);
            WriteLine(Callback(8, 3));
        }
    }
}
