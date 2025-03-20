namespace MathCode;

public interface FirstI
{
    void First_Method();
    public void Another_Method();
}

public interface TwoI
{
    int Two_Method();


}

public class InterfaceType : FirstI , TwoI
{
    
    public void Another_Method()
    {
        System.Console.WriteLine("interface Another method ");
    }
    public void First_Method()
    {
        System.Console.WriteLine(" my first interface method");
    }

    public int Two_Method()
    {
        System.Console.WriteLine("Two interface method");
        return 1;
    }
}