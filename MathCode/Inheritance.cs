namespace MathCode;

public interface FirstInterface
{
    void oneinterface();
}
public interface TwoInterface
{
    void Two_MethodInterface();
}

public class A
{
    public void FirstABC ()
    {
        System.Console.WriteLine("class A method");
    }
}
public class B : A
{
    public void SecondXYZ ()
    {
        System.Console.WriteLine("class B method xyz");
    }
}


public class C : A, FirstInterface, TwoInterface
{
    public void Method_C()
    {
        System.Console.WriteLine("Method C called");
    }

    public void oneinterface()
    {
        System.Console.WriteLine("First Interface implementation");
    }
    public void Two_MethodInterface()
    {
        System.Console.WriteLine("2nd Interface implementation");
    }
}
public class Inheritance : B
{
    public void ThirdMethod ()
    {
        System.Console.WriteLine("class Third C method");
    }
}