
public sealed class SealedClass    
{
    
    public  int Digit;

    public void ABC_Method()
    {
        System.Console.WriteLine(" sealed method " + Digit);
    }
}

// public class ChildSealed : SealedClass
// {
//     public void childMethod()
//     {
//         Digit = 45;
//         ABC_Method();
//     }
// }