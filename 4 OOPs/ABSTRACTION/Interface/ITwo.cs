
public interface ITwo
{
    public  void Method22();

}

public class Next : ITwo
{
    public void Method22()
    {
        System.Console.WriteLine(" Interface method 22 ");

    }
    public void Method_Next()
    {
        System.Console.WriteLine(" Next ");
    }
}

