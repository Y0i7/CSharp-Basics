

public class Practice3
{
    const string[] text = ["You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to"];

    const string[] good = ["look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!"];
    const string[] bad = ["fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life."];
    const string[] neutral = ["appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature."];

    public static void Main(string[] args)
    {

        var random = new Random();
        int luck = random.Next(100);

        Console.WriteLine("A fortune teller whispers the following words:");

        var fortune = FindFortune(luck);
        ShowMessage(fortune);

        static string[] FindFortune(int luck)
        {
            string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));

            return fortune;
        }

        static void ShowMessage(string[] fortune)
        {
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"{text[i]} {fortune[i]} ");
            }
        }
    }

}