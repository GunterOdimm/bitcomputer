using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    abstract class Product1
    {
        private static int serial = 0;
        public String SerialID
        {
            get { return String.Format("{0:d5}, serial++"); }
        }
        abstract public DateTime ProductDate
        {
        get; set;
        }
    }

    class MyProduct : Product1
    {
        public override DateTime ProductDate { get; set; }
    }
}
