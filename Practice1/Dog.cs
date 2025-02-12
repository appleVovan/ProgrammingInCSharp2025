using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMA.ProgrammingInCSharp2025.Practice1
{
    public enum DogType
    {
        Poodle = 2,
        Labrador = 4,
        Labradoodle = 6
    }

    partial class Dog
    {
        private int age;
        private DogType breed;

        public int Age 
        { 
            get
            {
                return age;
            }
            set
            {
                if (value >= 0)
                    age = value;
                else
                    throw new Exception();
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

        public DogType Breed { get => breed; set => breed = value; }

        public void MyMethod()
        {
            int val1 = Age;
            Age = 5;

            breed = DogType.Labrador;

        }
    }
}
