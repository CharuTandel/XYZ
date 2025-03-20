namespace MathCode;

public class Derived : Baseclass
{
    public Derived()
    {
        System.Console.WriteLine(" Derived class default constructor");
    }
    public Derived(string namevalue): base(namevalue)
    {
        System.Console.WriteLine("Derived parameterized " + namevalue);
    }

    public void Mymethod()
    {
        System.Console.WriteLine(" Mymethod called derived");
    }
}