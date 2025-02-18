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
            MyMethodObject(myObject);
            Console.WriteLine(myObject.MyProperty);
        }

        static void MyMethodObject(MyClass myObject)
        {
            myObject = new MyClass();
            myObject.MyProperty = 6;
            Console.WriteLine(myObject.MyProperty);
        }
    }
}
