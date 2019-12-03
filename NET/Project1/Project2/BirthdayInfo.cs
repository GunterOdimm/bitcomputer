using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    // 프러퍼티 개념 SETTER 와 GETTER의 개념과 일맥 상통하지만
    // 이경우에는 특이하게도 초기값을 설정할수 있다. Main11에서 확인해보자.
    class BirthdayInfo
    {/*
        private String name;
        private DateTime birthday;
*/
        public String Name
        {
            get; set;
            //{
            //    return name;
            //}
            //set
            //{
            //    name = value;
            //    // 여기서 value는 고정된 변수명입니다.(바꾸면 안됨)
            //}
        } = "Anonymous";
        public DateTime Birthday
        { get; set; } = new DateTime(1, 1, 1);
        public int Age
        { 
            get
            {
                return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;
            }
        }
    }
}
