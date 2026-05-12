using System;
public class Activity3
{
    public static void Main()
    {
        var wordToReverse = "Hola amigo mio";

        string resultado = ReverseWord(wordToReverse.Split(" "));

        Console.WriteLine("Reversed: {0}", resultado);
    }

    static string ReverseWord(string[] words)
    {
        var wordPosition = words.Length - 1;
        string[] reversedWords = new string[words.Length];

        for (var i = 0; i < words.Length; i++)
        {
            reversedWords[wordPosition] = ReverseWord(words[i]); 
            wordPosition --;
        }
        return string.Join(" ", reversedWords);
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
