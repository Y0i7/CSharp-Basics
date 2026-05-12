using System;
public class Activity4
{
    public static void Main()
    {
        const string resultFormat = "{0}: {1}";
        const string tittle = "Es Palindromo?\n";

        string[] words = { "racecar", "talented", "deified", "tent", "tenet" };

        var results = isPalindrome(words);

        Console.WriteLine(tittle);

        for (var i = 0; i < words.Length; i++)
        {
            Console.WriteLine(
            resultFormat,
            words[i],
            results[i]
            );
        }

    }

    static bool[] isPalindrome(string[] strs)
    {
        bool[] results = new bool[strs.Length];

        string[] reversedWords = ReverseWord(strs);
        var reversePosition = reversedWords.Length - 1;

        for (var i = 0; i < results.Length; i++)
        {
            results[i] = isPalindrome(strs[i] == reversedWords[reversePosition]);
            reversePosition --;
        }

        return results;
    }
    static bool isPalindrome(bool booleanExpression)
    {

        return (booleanExpression) ? true : false;
    }

    static string[] ReverseWord(string[] words)
    {
        var wordPosition = words.Length - 1;
        string[] reversedWords = new string[words.Length];

        for (var i = 0; i < words.Length; i++)
        {
            reversedWords[wordPosition] = ReverseWord(words[i]);
            wordPosition--;
        }
        return reversedWords;
    }

    static string ReverseWord(string str)
    {
        var newString = "";
        for (var i = str.Length - 1; i >= 0; i--)
        {
            newString += str[i];
        }
        return newString;
    }
}
