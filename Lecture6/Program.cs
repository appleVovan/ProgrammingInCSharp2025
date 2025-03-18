namespace KMA.ProgrammingInCSharp2025.Lecture6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread myParallelOperation = new Thread(MyTask);

            myParallelOperation.Start();

            //Perform some actions

            myParallelOperation.Join();

            //process results
        }

        static void MyTask()
        {
            //Perform some operations
        }
    }
}
