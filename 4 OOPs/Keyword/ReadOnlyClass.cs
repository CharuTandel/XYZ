
public class ReadOnlyClass
{
    public readonly int detail;    // Readonly Field can only once initialized through Constructor at RunTime from console 
                                   //  With every new object creation a new value will be assigned to Readonly field
    public ReadOnlyClass(int value)
    {
        detail = value;
    }

    public void Method1()
    {
        // detail = 3;
        System.Console.WriteLine(" Readonly method here " + detail);

    }
}