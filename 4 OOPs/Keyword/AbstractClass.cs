// Abstract method  MUST-be  Overriden / Modify in Derived class with new implementation  using override keyword


public abstract class AbstractClass
{
    public abstract void AMethod1();   //  abstract method " Must be Overriden" [Mandatory] in child class 
                                       //   abstarct method must compulsory implemented in Child class
    public void ConcreteMethod()
    {
        System.Console.WriteLine(" concrete method ");
    }
}

public class Child1 : AbstractClass
{
    public override void AMethod1()          // override keyword used to Replace or Modify the base method in derived class
    {
        System.Console.WriteLine(" Abstract Method ");
    }
}