namespace MathCode;

public class Polymorphism
{
    // MethodOverloading  - same Method Name but Different Parameters
    public static void Addition (int a, int b)
    {
        int result = a + b;
          System.Console.WriteLine($"Addition  - {result}");
    }

    public static int Addition(int a , int b,int c)
    {
        return (a + b + c) ;
    }

    public static string Addition(string a, string b)
    {
       return a + b;
    }

    public static double Addition(double a, double b,double c)
    {
        return a + b + c;
    }

    public static void Addition(int x)
    {
        System.Console.WriteLine("value of x " + x);
    }

}