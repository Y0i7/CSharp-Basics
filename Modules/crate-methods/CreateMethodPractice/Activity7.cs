using System;
using System.Runtime.InteropServices;
public class Activity7
{
    private static readonly string _ShowGroupFormat = "\t{0}";
    private static readonly string _GroupTittleFormat = "Group {0} :";
    private static readonly Random random = new();
    private static readonly string[] pettingZoo =
    {
        "alpacas", "capybaras", "chickens", "ducks", "emus", "geese",
        "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws",
        "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
    };



    public static void Main(string[] args)
    {
        PlanSchoolVisit("School A");
        PlanSchoolVisit("School B", 3);
        PlanSchoolVisit("School C", 2);
    }

    private static void PlanSchoolVisit(string schoolName, int groups = 6)
    {
        RandomizeAnimals();
        string[,] group = AssignGroup();
        Console.WriteLine(schoolName);
        PrintGroup(group);
    }

    private static void RandomizeAnimals()
    {


        for (var i = 0; i < pettingZoo.Length; i++)
        {
            var r = random.Next(i, pettingZoo.Length);

            string? temp = pettingZoo[i];
            pettingZoo[i] = pettingZoo[r];
            pettingZoo[r] = temp;
        }
    }

    private static string[,] AssignGroup(int groups = 6)
    {
        var start = 0;

        string[,] result = new string[groups, pettingZoo.Length / groups];

        for (var i = 0; i < result.GetLength(0); i++)
        {
            for (var j = 0; j < result.GetLength(1); j++)
            {
                result[i, j] = pettingZoo[start++];
            }
        }
        return result;
    }

    private static void PrintGroup(string[,] group)
    {
        for (var i = 0; i < group.GetLength(0); i++)
        {
            Console.Write(
                _GroupTittleFormat,
                i + 1
            );
            for (var j = 0; j < group.GetLength(1); j++)
            {
                Console.Write(
                    _ShowGroupFormat,
                    group[i, j]
                );
            }
            Console.WriteLine();
        }

    }



}

