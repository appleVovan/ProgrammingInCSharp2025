namespace KMA.ProgrammingInCSharp2025.Practice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 1000;

            byte y = checked((byte)x);

            Console.WriteLine(y);
        }
    }
}
