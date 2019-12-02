using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Employee
    {
        private String name;
        private String position;

        public void SetName(string name)
        {
            this.name = name;
        }
        public String GetName()
        {
            return name;
        }
        public void SetPosition(String position)
        {
            this.position = position;
        }
        public String GetPosition()
        {
            return position;
        }
    }
}
