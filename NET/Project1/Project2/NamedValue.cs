using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class NamedValue : INameValue
    {
        public String Name
        {
            get; set;
        }
        public String Value
        {
            get; set;
        }
    }
}
