namespace KMA.ProgrammingInCSharp2025.Practice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myInt = 5;
            MyMethodInt(ref myInt);
            Console.WriteLine(myInt);
        }

        static void MyMethodInt(ref int myInt)
        {
            myInt = 6;
            Console.WriteLine(myInt);
        }
    }
}
