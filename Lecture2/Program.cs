namespace KMA.ProgrammingInCSharp2025.Lecture2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Initialization
            Student mystudent1 = new Student { FirstName = "Steve", LastName = "Jobs" };

            Student mystudent2 = new Student();
            mystudent1.FirstName = "Bill";
            mystudent1.LastName = "Gates";
            #endregion
        }
    }
}
