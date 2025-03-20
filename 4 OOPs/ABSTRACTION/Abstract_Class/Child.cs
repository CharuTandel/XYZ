namespace Abstract_Class;

public class Child : Parent
{

    public override void Calculation()
    {
        System.Console.WriteLine(" Calculation method in child ");
    }


    public void Method2()
    {
        System.Console.WriteLine(" Child Method");

        // Calculation();
    }

}