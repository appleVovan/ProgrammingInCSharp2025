using KMA.ProgrammingInCSharp2025.Lecture2.Copy;
using KMA.ProgrammingInCSharp2025.Lecture2.Original;

namespace KMA.ProgrammingInCSharp2025.Lecture2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Initialization
            var mystudent1 = new Copy.Student { FirstName = "Steve", LastName = "Jobs" };

            Student mystudent2 = new Student();
            mystudent1.FirstName = "Bill";
            mystudent1.LastName = "Gates";
            #endregion

            #region Variable Initialization

            #endregion
        }
    }
}
