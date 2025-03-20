
public class Single          //   A  -->  B
{
    public void MethodSingle()
    {
        System.Console.WriteLine(" This is Base Single Method ");
    }
}

public class Child : Single
{
    public void ChildMethod()
    {
        System.Console.WriteLine(" single child Method ");
        
    }
}