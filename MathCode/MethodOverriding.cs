namespace MathCode;

public class MethodOverriding
{
    public virtual void DisplayName()
    {
        Console.WriteLine(" Base Class - Virtual method");
    }
}

public class First_Derived : MethodOverriding
{
    public override void DisplayName()
    {
        System.Console.WriteLine(" First Derived Name");
    }
}

public class Two_Derived : MethodOverriding
{
    public override void DisplayName()
    {
        System.Console.WriteLine(" Two Derived Name");

    }
}

public class Third_Derived : MethodOverriding
{
    public override void DisplayName()
    {
        System.Console.WriteLine(" Third Name");
    }

}

