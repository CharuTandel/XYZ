using Abstract_Class;

public abstract class Parent                 //  Abstract Class contains both Abstract & Concrete Method
{
    public int num = 23;
    public Parent(int y)
    {
        num = y;
    }

    public abstract void Calculation();      //  Abstract Method without implementation 

    public static void Print1()
    {
        System.Console.WriteLine(" static Print Hello  " );
    }

    public  void Print()
    {
        System.Console.WriteLine(" Print Hello  " + num);
    }

}