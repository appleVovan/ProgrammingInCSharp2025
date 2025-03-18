namespace KMA.ProgrammingInCSharp2025.Lecture6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread myParallelOperation = new Thread(MyTask);

            myParallelOperation.Start();
        }

        static void MyTask()
        {
            //Perform some operations
        }
    }
}
