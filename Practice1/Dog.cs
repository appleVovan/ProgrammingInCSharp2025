using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMA.ProgrammingInCSharp2025.Practice1
{
    partial class Dog
    {
        private int age;

        public int Get_Age()
        {
            return age;
        }

        public void Set_Age(int val)
        {
            age = val;
        }

        public int Age 
        { 
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public void MyMethod()
        {
            int val = Get_Age();
            Set_Age(5);

            int val1 = Age;
            Age = 5;
        }
    }
}
