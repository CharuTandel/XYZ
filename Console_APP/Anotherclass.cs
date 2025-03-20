namespace Console_APP;

public class Anotherclass :Oneclass
{
    public Anotherclass(string value):base(value)
    {
        
    }
    public void anothermethod()
    {
        Console.WriteLine(" Derived class method");
    }
}