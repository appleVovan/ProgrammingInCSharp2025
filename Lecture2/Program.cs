using KMA.ProgrammingInCSharp2025.Lecture2.Copy;
using KMA.ProgrammingInCSharp2025.Lecture2.Original;
using CopyStudent = KMA.ProgrammingInCSharp2025.Lecture2.Copy.Student;
using OriginalStudent = KMA.ProgrammingInCSharp2025.Lecture2.Original.Student;
using циферка = System.Int32;

namespace KMA.ProgrammingInCSharp2025.Lecture2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Initialization
            var mystudent1 = new CopyStudent { FirstName = "Steve", LastName = "Jobs" };
            var mystudent3 = new CopyStudent { FirstName = "Steve", LastName = "Jobs" };

            OriginalStudent mystudent2 = new OriginalStudent();
            mystudent1.FirstName = "Bill";
            mystudent1.LastName = "Gates";
            #endregion

            #region Variable Initialization
            циферка i, j, k;
            i = j = k = 100;
            #endregion

            #region New Line
            string tempVar = "My name is Volodymyr." + Environment.NewLine + "My age is 30.";

            string str1 = "Volodymyr";
            string str2 = "Volodymyr";

            if (str1==str2)
            {

            }
            #endregion

            if (SaveToServer())
            {
            }
            else
            {
                if (SaveToServer())
                {
                }
                else
                {
                }
            }
        }

        private static bool SaveLocalCopy()
        {
            return true;
        }

        private static bool SaveToServer()
        {
            return true;
        }
    }
}
