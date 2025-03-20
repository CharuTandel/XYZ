namespace MathCode;

public class evenodd
{
    public static  void EvenMethod()
    {
        System.Console.WriteLine(" Enter a number ");
        int num = Convert.ToInt32(System.Console.ReadLine());
        

        if(num % 2 == 0)
        {
            System.Console.WriteLine(" Even number " +num);
        }
        else
        {
            System.Console.WriteLine(" odd number " +num);
        }

    }
}