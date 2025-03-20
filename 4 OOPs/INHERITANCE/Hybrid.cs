// Hybrid is combination of Hierarchical inheritance [ A --> B & C ] and Multiple inheritance [ B & C --> D ]

public class Hybrid
{
    public void Method_Hybrid()
    {
        System.Console.WriteLine(" Base Hybrid Method ");
    }
}

public class B1 : Hybrid
{
    public void B1_Method()
    {
        System.Console.WriteLine(" B1 Method derived from Hybrid ");
    }
}

public class B2 : Hybrid
{
    public void B2_Method()
    {
        System.Console.WriteLine(" B2 Method ");
    }
}


public interface C
{
    public void C_Method();
}


public class D : B1, C
{
    public void C_Method()
    {
        System.Console.WriteLine(" Interface Method C ");
    }

    public void D_Method()
    {
        System.Console.WriteLine(" Own Method D ");

    }
}