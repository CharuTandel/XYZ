namespace MathCode;

public class factorial
{
    // 5! = 5 * 4 * 3 * 2 * 1 = 120
    public static void FactMethod()
    {
        System.Console.WriteLine(" Enter a number ");
        int num = Convert.ToInt32(Console.ReadLine());

        // int num = 5;
        int temp = 1;

        for (int i = 1; i <= num; i++)
        {
            temp = temp * i;

        }
        System.Console.WriteLine(temp);

    }
}
