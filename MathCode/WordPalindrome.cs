namespace MathCode;

public class WordPalindrome
{
    public static void LetterPalindrome()
    {

        System.Console.WriteLine(" Enter a Word ");
        string newword = Console.ReadLine();

        // string input = new string(newword.Where(char.IsLetterOrDigit).ToArray()).ToLower();

        List<char> convertword = new List<char>(newword);

        List<char> reversed = new List<char>();


        for (int i = convertword.Count; i > 0; i--)
        {
        
            reversed.Add(convertword[i - 1]);

        }

        // reversed words/letters
        // foreach (var item in reversed)
        // {
        //     System.Console.Write(item);
        // }

        if (convertword.SequenceEqual(reversed))
        {
             System.Console.WriteLine(" Yes Palindrome word  " + newword);
        }
        else
        {
             System.Console.WriteLine(" Not The Palindrome  " + newword);
        }


    }
}