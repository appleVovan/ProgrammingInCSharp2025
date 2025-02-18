namespace KMA.ProgrammingInCSharp2025.Practice1
{
    internal class Program
    {
        class MyClass
        {
            public int MyProperty { get; set; }
        }
        static void Main(string[] args)
        {
            MyClass myObject = new MyClass();
            myObject.MyProperty = 5;
            MyMethodObject(ref myObject);
            Console.WriteLine(myObject.MyProperty);
        }

        static void MyMethodObject(ref MyClass myObject)
        {
            myObject = new MyClass();
            myObject.MyProperty = 6;
            Console.WriteLine(myObject.MyProperty);
        }
    }
}
