namespace KMA.ProgrammingInCSharp2025.Lecture6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread myParallelOperation = new Thread(MyTask);

            myParallelOperation.Start(new object());

            //Perform some actions

            myParallelOperation.Join();

            //process results
        }

        static void MyTask(object obj)
        {
            //Perform some operations
        }
    }
}
