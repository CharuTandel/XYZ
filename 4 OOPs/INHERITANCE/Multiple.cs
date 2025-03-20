//    Multiple Base Class like A and B  has single Child class C

public class Multiple                   // Multiple inheritance in c# does not supported directly with Base classes                                        //   with Base class 
{                                         //  but , Using INTERFACE  --> we can achieve multiple inheritance
    public void A()
    {
        System.Console.WriteLine(" Multiple Base Method  A");
    }
}
// public class Base
// {
//     public void B()
//     {
//         System.Console.WriteLine("  Base Method B ");
//     }

// }

public interface IBase
{
    public void B();
}


public interface INext
{
    public void Next();
}

// public abstract class Abst
// {
//     public abstract void Abst_meth();
// }

public class Derived : Multiple, IBase, INext
{
    public void B()
    {
        System.Console.WriteLine("  interface  - B Base Method  ");

    }
    public void Next()
    {
        System.Console.WriteLine("  interface  - Next ");

    }
    public void C()
    {
        System.Console.WriteLine(" C Derived Method ");

    }

}