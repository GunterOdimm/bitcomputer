using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Project3
{
    delegate void OnlineShopping(String loaction);
    class DelegateChainEx
    {
        static void OrderGoods(String location)
        {
            WriteLine($"장바구니내 물건을 {location}으로 가져다 주세요!");
        }

        static void SpecialOrder(String location)
        {
            WriteLine($"{location}에 사람이 없으면 문앞에 두시고 문자주세요!");
        }

        static void main(String[] args)
        {
            OnlineShopping shopper = new OnlineShopping(OrderGoods) + new OnlineShopping(SpecialOrder);
            // 델리게이트는 +순서대로 작동하며 이를 델리게이트 체인 이라고 말한다.
            shopper("우리집");
        }
    }
}
