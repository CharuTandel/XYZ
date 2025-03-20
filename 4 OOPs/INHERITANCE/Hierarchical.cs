//  A  has multiple Child like B AND C

public class Hierarchical
{
    public void Method_Hierarchical()
    {
        System.Console.WriteLine(" This is a Base Hierarchical ");
    }
}

public class Child_B : Hierarchical
{
    public void Meth_ChildB()
    {
        System.Console.WriteLine(" Child B Method ");
    }
}

public class Child_C : Hierarchical
{
    public void ChildC_Meth()
    {
        System.Console.WriteLine(" Method - Child C ");
    }
}