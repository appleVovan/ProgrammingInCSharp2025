using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMA.ProgrammingInCSharp2025.Lecture2.Original
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is Student)) 
                return false;
            Student castedObj = (Student)obj;
            if (castedObj == null)
                return false;
            return FirstName == castedObj.FirstName && LastName == castedObj.LastName;
        }
    }
}
