using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class Main09
    {
        // 행동양식의 강제화 할때 사용된다.(메소드의 명을 강제화 시키시도 한다)
        static void main(String[] args)
        {
            AbstractBase obj = new Derived();
            obj.AbstractMethodA();
            obj.PublicMethodA();
        }
    }
}
