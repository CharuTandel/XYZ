namespace MathCode;

public class reversed
{
    public static void Mymethod()
    {
         System.Console.WriteLine(" Enter a number ");
        int num = Convert.ToInt32(Console.ReadLine());
        int temporary = 0;

        while (num > 0)
        {
            int mod = num % 10;

            temporary = (temporary * 10) + mod;
 
            
            int div = num / 10;

            num = div;
        }

        System.Console.WriteLine(" Reversed number " + temporary);

    }
}