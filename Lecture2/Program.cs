using KMA.ProgrammingInCSharp2025.Lecture2.Copy;

namespace KMA.ProgrammingInCSharp2025.Lecture2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Initialization
            var mystudent1 = new Student { FirstName = "Steve", LastName = "Jobs" };

            Original.Student mystudent2 = new Original.Student();
            mystudent1.FirstName = "Bill";
            mystudent1.LastName = "Gates";
            #endregion
        }
    }
}
