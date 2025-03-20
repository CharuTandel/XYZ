namespace MathCode;

public class fibonacci
{
    //  fibonacci series -   0,1,1,2,3,5,8,13,21,34,55,89,...

    public static void fibonacciMethod()
    {

        System.Console.WriteLine(" Enter a number ");
        int num = Convert.ToInt32(Console.ReadLine());


        int first = 0;
        int second = 1;
        int result = 1;
        List<int> listx = new List<int>();
        listx.Add(first);


        while (result <= num)
        {
            listx.Add(result);

            result = first + second;

            first = second;
            second = result;
        }

        foreach (var item in listx)
        {

            System.Console.Write($"{item} ,");
        }

    }
}