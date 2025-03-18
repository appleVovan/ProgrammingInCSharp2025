namespace KMA.ProgrammingInCSharp2025.Lecture6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CancellationTokenSource tokenSource = new CancellationTokenSource();
            var worker = new MyBackgroundWorker(new Tuple<string, int, double>("pram", 7, 1.1), tokenSource.Token);

            Thread myParallelOperation = new Thread(worker.Process);

            myParallelOperation.Start();

            //Perform some actions

            tokenSource.Cancel();

            myParallelOperation.Join(5000);

            //process results
            Console.WriteLine(worker.OutputPrams);
        }

        class MyBackgroundWorker
        {
            private Tuple<string, int, double> _inputPrams;
            private Tuple<string, int, double> _outputPrams;
            private readonly CancellationToken _cancellation;

            public Tuple<string, int, double> OutputPrams {  get { return _outputPrams; } }

            public MyBackgroundWorker(Tuple<string, int, double> inputPrams, CancellationToken cancellation)
            {
                _inputPrams = inputPrams;
                _cancellation = cancellation;
            }

            public void Process()
            {
                string param = _inputPrams.Item1;

                while (!_cancellation.IsCancellationRequested)
                {
                    if (!GetNewTask())
                    {
                        for(int i=0; i<10; i++)
                        { 
                            Thread.Sleep(1000); 
                        }                            
                        continue;
                    }
                    //Perform step1
                    if (!_cancellation.IsCancellationRequested)
                    {
                        //Finish Processing
                        break;
                    }
                    //Perform step2
                    if (!_cancellation.IsCancellationRequested)
                    {
                        //Finish Processing
                        break;
                    }
                    //Perform step3
                    if (!_cancellation.IsCancellationRequested)
                    {
                        //Finish Processing
                        break;
                    }
                }

                _outputPrams = new Tuple<string, int, double>("result", 3, 0.4);
            }

            private bool GetNewTask()
            {
                return true;
            }
        }
    }
}
