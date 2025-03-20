namespace MathCode;

// abstract keyword used before class and method both 
public abstract class AbstractType
{
    //  method without body
    public abstract void Method1();

    public void Method2()
    {
        System.Console.WriteLine(" Regular method with body");
    }
}

public class DerivedAbstract : AbstractType
{
   public override void Method1()
   {
    System.Console.WriteLine(" Abstract method implemented ");
   }
}