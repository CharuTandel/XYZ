public class NewClass
{
    public void BaseMethod()
    {
        System.Console.WriteLine("Base  New class Method ");
    }
}



public class CHILD : NewClass
{

    public  new void BaseMethod()
    {
        System.Console.WriteLine(" Base method in Derived/Child class");
    }

    public void ChildMethod()
    {
        BaseMethod();
        System.Console.WriteLine(" this is child method ");
    }
}