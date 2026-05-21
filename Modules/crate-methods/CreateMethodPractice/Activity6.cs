using System;
using System.Runtime.InteropServices;

/*
        This program allows you to play throw the dice against the pc,
        this structure consist in a main method to start the game, a shouoldPlay
        method to check if player would like to keep playing, a WintOrLose method
        to figure out who wins and who loses by findig the higher score gotten by
        the dice, and finaly an exception Method to inform the user what happened
        in case of an error comited while the shouldPlay option choose.
*/
public class Activity6
{
    private static readonly string _ShowingResultsFormat = "\t\tGame Results \n--------------------\n\tPlayer -> {0}\n\tCPU -> {1} \n\t\t{2} Wins!!!";
    private static readonly string _AskForPlayingFormat = "{0} Again? s/n";
    private static readonly string _StartGameIndicatorFormat = "\t\tCPU scores {0}\n--------------------------\n\nNow is your turn press ENTER to throw the dice";


    public static void Main()
    {
        var dice = new Random();
        var isPlaying = true;

        do
        {
            var target = dice.Next(1, 6);

            Console.WriteLine(
                _StartGameIndicatorFormat,
                target
            );

            Console.ReadKey();

            var score = dice.Next(1, 6);

            var isWinner = WinOrLose(target, score);

            isPlaying = ShouldPlay(isWinner);

        } while (isPlaying);
    }

    static bool ShouldPlay(bool isWinner)
    {
        Console.WriteLine(
            _AskForPlayingFormat,
            isWinner ? "Play" : "Try"
        );

        string? choose = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(choose))
            choose = "ERROR";

        var shouldPlay = choose.ToLower() switch
        {
            "si" => true,
            "s" => true,
            "n" => false,
            "no" => false,
            _ => BadChooseException(choose.ToUpper())
        };

        return shouldPlay;
    }

    static bool WinOrLose(int target, int score)
    {
        Console.Clear();
        var isPlayerWinner = score > target;
        Console.WriteLine(
            _ShowingResultsFormat,
            score,
            target,
            isPlayerWinner ? "Player" : "CPU"
        );

        return isPlayerWinner;
    }

    static bool BadChooseException(string data)
    {
        const string MessageFormat = "{0} is not a valid option, try again";
        Console.WriteLine(
            MessageFormat,
            data
        );
        Console.ReadKey();
        Console.Clear();

        return false;
    }


}

