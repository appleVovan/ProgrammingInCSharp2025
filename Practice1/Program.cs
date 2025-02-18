namespace KMA.ProgrammingInCSharp2025.Practice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myInt = 5;
            MyMethodInt(myInt);
            Console.WriteLine(myInt);
        }

        static void MyMethodInt(int myInt)
        {
            myInt = 6;
            Console.WriteLine(myInt);
        }
    }
}
