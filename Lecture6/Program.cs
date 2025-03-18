namespace KMA.ProgrammingInCSharp2025.Lecture6
{
    internal class Program
    {
        private static Tuple<string, int, double> _inputPrams;
        private static Tuple<string, int, double> _outputPrams;
        static void Main(string[] args)
        {
            Thread myParallelOperation = new Thread(MyTask);

            _inputPrams = new Tuple<string, int, double>("pram", 7, 1.1);

            myParallelOperation.Start();

            //Perform some actions

            myParallelOperation.Join();

            //process results
            Console.WriteLine(_outputPrams);
        }

        static void MyTask()
        {
            string param = _inputPrams.Item1;
            //Perform some operations
            _outputPrams = new Tuple<string, int, double>("result", 3, 0.4);
        }
    }
}
