namespace MathCode;

public class palindrome
{
    public static void VerifyPalindrome()
    {
        System.Console.WriteLine(" Enter a number ");

        int num = Convert.ToInt32(Console.ReadLine());

        int original = num;
        int answer = 0;


        while (num > 0)

        {
            int mod = num % 10;

            answer = (answer * 10) + mod;

            int divi = num / 10;

            num = divi;
        }


        if (answer == original)
            System.Console.WriteLine("Result will be palindrome " + original);
        else
            System.Console.WriteLine("Not a palindrome " + original);


    }
}