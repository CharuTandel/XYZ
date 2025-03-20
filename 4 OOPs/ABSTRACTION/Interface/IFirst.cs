public interface IFirst
{
    
    public   void Method1(string Name);

    public int Method11();

}

public class Child : IFirst, ITwo
{
    public void Method1(string Value)
    {
        System.Console.WriteLine(" My Value is " + Value);
    }

    public int Method11()
    {
        System.Console.WriteLine(" method 11  ");
        return 11;
    }

    public void Method22()
    {
        System.Console.WriteLine(" Hello method 22 here ");
    }
}