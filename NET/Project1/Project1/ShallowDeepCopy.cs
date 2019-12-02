using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class ShallowDeepCopy
    {
        public int Field1;
        public int Field2;

        public ShallowDeepCopy DeepCopy()
        {
            ShallowDeepCopy newClass = new ShallowDeepCopy();
            newClass.Field1 = Field1;
            newClass.Field2 = Field2;

            return newClass;
        }
    }
}
