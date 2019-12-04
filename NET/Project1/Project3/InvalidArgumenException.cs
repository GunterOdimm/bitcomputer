using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    class InvalidArgumenException : Exception
    {
        public InvalidArgumenException() { }
        public InvalidArgumenException(String message) : base(message) { }

        public object Argument
        {
            get; set;
        }
        public String Range
        {
            get; set;
        }
    }
}
