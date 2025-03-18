﻿namespace KMA.ProgrammingInCSharp2025.Lecture6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var worker = new MyBackgroundWorker(new Tuple<string, int, double>("pram", 7, 1.1));

            Thread myParallelOperation = new Thread(worker.Process);

            myParallelOperation.Start();

            //Perform some actions

            worker.StopWorker();

            myParallelOperation.Join(5000);

            //process results
            Console.WriteLine(worker.OutputPrams);
        }

        class MyBackgroundWorker
        {
            private Tuple<string, int, double> _inputPrams;
            private Tuple<string, int, double> _outputPrams;
            private bool _isRunning = true;

            public Tuple<string, int, double> OutputPrams {  get { return _outputPrams; } }

            public MyBackgroundWorker(Tuple<string, int, double> inputPrams)
            {
                _inputPrams = inputPrams;
            }

            public void StopWorker()
            {
                _isRunning = false;
            }

            public void Process()
            {
                string param = _inputPrams.Item1;

                while (_isRunning)
                {
                    //Perform some operations
                }

                _outputPrams = new Tuple<string, int, double>("result", 3, 0.4);
            }
        }
    }
}
