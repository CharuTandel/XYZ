public class StaticClass       // static class does not support instance Constructors and "new" keyword   
{
    public static int Fieldname;       // static members are stored in static memory separately not on Heap_object

    // public StaticClass()             
    // {
    //     System.Console.WriteLine(" hello ");
    // }

    public static void Method1()
    {
        System.Console.WriteLine(" Static class method " + Fieldname);
    }


    public static void Method2()
    {
        System.Console.WriteLine(" normal class method " + Fieldname);
    }

}
public class ChildX : StaticClass
{

    public void MethodX()
    {
        Fieldname = 2311;
        Method1();
        Method2();
        StaticClass.Method1();
    }
}
