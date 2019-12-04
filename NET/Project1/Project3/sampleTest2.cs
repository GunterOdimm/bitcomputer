using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace Project3
{
    class sampleTest2
    {
        
    }
    delegate void EventHandler(String message);
    class MyNotifier
    {
        public event EventHandler DoAlarm;
        /* 
         * 이벤트 한정자.
         * 기껏 공개로 할당을 해놔도
         * notifier.DoAlarm("이렇게 호출이 안된다.");
         * 오직 선언된 클래스 내부에서만 사용하고자
         * 하고 만들어둔 특성때문이다.
         */

        public void Get369(int num)
        {
            int temp = num % 10;
            if (temp != 0 && temp % 3 == 0)
            {
                DoAlarm(String.Format("{0} : 짝", num));
            }
        }
    }

    class MainApp
    {
        static public void MyHandler(String Message)
        {
            WriteLine(Message);
        }
        static void Main(String[] args)
        {
            MyNotifier notifier = new MyNotifier();
            notifier.DoAlarm += new EventHandler(MyHandler);
            // 이벤트 한정자 들어간다 입벌려라

            for (int i = 1; i < 30; i++)
            {
                notifier.Get369(i);
            }
            notifier.DoAlarm("이건 호출이 안된다.");
        }
    }
}
