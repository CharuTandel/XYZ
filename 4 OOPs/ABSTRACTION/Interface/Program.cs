namespace Interface;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        // Next obj = new Next();
        // obj.Method_Next();
        // obj.Method22();

        Child obj1 = new Child();

        obj1.Method1(" Oreo ");

        System.Console.WriteLine(obj1.Method11());

        obj1.Method22();

    }
}
