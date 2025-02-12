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

        public string Name { get; set; }
        public string Identifier 
        { 
            get
            {
                return $"Name: {Name}, age: {Age}";
            }
        } 

        public void MyMethod()
        {
            int val1 = Age;
            Age = 5;
        }
    }
}
