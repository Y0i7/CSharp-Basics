const string Response = "{0} -> {1}";
const string InvalidGMTMessage = "Invalid GMT";

var scheduledTimes = new int[] { 800, 1200, 1600, 2000 };

var currentGMTValue = GenerateGMTValues();
var newGMTValue = GenerateGMTValues();

DisplayAdjustedTimes(scheduledTimes, currentGMTValue, newGMTValue);
DisplayAdjustedTimes(scheduledTimes, 6, -6);

static int GenerateGMTValues()
{
    var dice = new Random();

    var generatedValue = dice.Next(-12, 12);

    return generatedValue;
}

static void DisplayAdjustedTimes(int[] times, int currentGMT, int newGMT)
{
    var absoluteValueOfNewGMT = Math.Abs(newGMT);
    var absoluteValueOfCurrentGMT = Math.Abs(currentGMT);

    var diff = 0;


    if (absoluteValueOfNewGMT > 12 || absoluteValueOfCurrentGMT > 12)
    {
        Console.WriteLine(InvalidGMTMessage);
    }
    else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
    {
        diff = 100 * (absoluteValueOfNewGMT - absoluteValueOfCurrentGMT);
    }
    else
    {
        diff = 100 * (absoluteValueOfNewGMT + absoluteValueOfCurrentGMT);
    }

    for (var i = 0; i < times.Length; i++)
    {
        var newTime = (times[i] + diff) % 2400;
        Console.WriteLine(
            Response,
            times[i],
            newTime
        );
    }
}