namespace KMA.ProgrammingInCSharp2025.Practice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myInt;
            MyMethodInt(out myInt);
            Console.WriteLine(myInt);
        }

        static void MyMethodInt(out int myInt)
        {
            myInt = 6;
            Console.WriteLine(myInt);
        }
    }
}
