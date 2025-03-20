public abstract class OverrideClass                 // from abstract class we cannot create object,
{                                                  // becoz abstract class is incomplete
    public virtual void BaseVirtual()                 // virtual method
    {
        System.Console.WriteLine(" This is a Virtual Method of baseclass ");
    }

    public abstract void AbsMethod();               //  abstract method without body
}

public class Child4 : OverrideClass
{

    public override void AbsMethod()
    {
        System.Console.WriteLine(" Abstract method in derived class");
    }

    public override void BaseVirtual()
    {
        System.Console.WriteLine(" virtual in Child 4 class");
    }
}

public class Child2 : OverrideClass
{
    public override void AbsMethod()
    {
        System.Console.WriteLine(" Abstract method in child2");
    }
    
}