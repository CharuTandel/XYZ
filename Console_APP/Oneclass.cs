namespace Console_APP;

public class Oneclass
{

    private string Myname {get; set;}

    public Oneclass(string valuename)
    {
        Myname = valuename;
    }

    public void somemethod()
    {
        System.Console.WriteLine($" Base class method called {Myname} ");
    }
}