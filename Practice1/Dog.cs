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

        private void Foo()
        {

        }

        internal void Bar()
        {

        }

        protected void Gas()
        {

        }

        public void Talk(string value)
        {

        }

        public void Talk(int times, string value, bool sit)
        {

        }

        public void MyMethod()
        {
            int val1 = Age;
            Age = 5;

            breed = DogType.Labrador;

            switch (breed)
            {
                case DogType.Poodle:
                    break;
                case DogType.Labrador:
                    break;
                case DogType.Labradoodle:
                    break;
            }

        }
    }
}
