namespace MathCode;

public class prime
{
    // prime number =  divide by 1 or number itself 
    //  prime number = 2, 3, 5, 7, 11, 13, 17, 19, 23, 29
    public static void primeMethod()
    {
        
        System.Console.WriteLine(" Enter a number ");
        int num = Convert.ToInt32(Console.ReadLine());

        int count = 0;

        for (int i = 1; i <= num; i++)
        {
            if (num % i == 0)
            {
                count = count + 1;
            }
        }

        if (count == 2)
        {
            System.Console.WriteLine(" Yes a prime number " + num);
        }
        else
        {

            System.Console.WriteLine(" Not prime  " + num);
        }

    }
}