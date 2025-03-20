namespace Console_APP;

class Program
{
    static void Main(string[] args)
    {
       System.Console.WriteLine(" Hello !!");

       Anotherclass obj = new Anotherclass("Testdata");

       obj.anothermethod();

    //    obj.Myname =  " Hello inheritance ";

       obj.somemethod();

    Oneclass obj2 = new Oneclass("ABC");

    
    //  obj2.Myname = " Base property";

     obj2.somemethod();

    //  System.Console.WriteLine($" return a value {obj2.Myname}" );


    }
}
