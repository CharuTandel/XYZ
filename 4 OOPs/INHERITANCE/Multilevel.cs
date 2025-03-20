public class Multilevel         //   A  -->  B  -->  C
{
    public void MethodMultilevel()
    {
        System.Console.WriteLine(" This is a Multilevel method base class");
    }
}

public class ChildB : Multilevel
{
    public void ChildBMethod()
    {

        System.Console.WriteLine(" Child B Method Multilevel ");
    }
}


public class ChildC : ChildB
{
    public void ChildCMethod()
    {
        System.Console.WriteLine(" Child C  Method Multilevel ");

    }
}