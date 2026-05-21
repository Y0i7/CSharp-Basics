/*
Codigo para verificar monedas que puedan ofrecer un cambio exacto a una cantidad
definida "target", utiliza el método TwoCoins() el cual retornará un arreglo de 
dos dimensiones con las posiciónes que coinciden para cumplir la condición de dar la cantidad
exacta esperada
*/
using System;
public class Activity5
{
    public static void Main()
    {
        const string format = "Change found at positions : {0} and {1} for {2}";
        const string notFoundFormat = "No two coins make change for: {0}";

        int target = 60;
        int[] coins = [5, 5, 50, 25, 25, 10, 5];
        int[,] result = TwoCoins(coins, target);

        if (result.Length == 0)
        {
            Console.WriteLine(
                notFoundFormat,
                target
            );
        }
        else
        {
            for (var i = 0; i < result.GetLength(0); i++)
            {
                if (result[i, 0] == -1 && result[i, 1] == -1)
                {
                    break;
                }
                Console.WriteLine(
                        format,
                        result[i, 0],
                        result[i, 1],
                        target
                        );
            }

        }
    }

    static int[,] TwoCoins(int[] coins, int target)
    {
        int[,] result = { { -1, -1 }, { -1, -1 }, { -1, -1 }, { -1, -1 }, { -1, -1 } };
        int count = 0;

        for (int curr = 0; curr < coins.Length; curr++)
        {
            for (int next = curr + 1; next < coins.Length; next++)
            {
                if (coins[curr] + coins[next] == target)
                {
                    result[count, 0] = curr;
                    result[count, 1] = next;
                    count++;
                }
                if (count == result.GetLength(0))
                {
                    return result;
                }
            }
        }
        return (count == 0) ? new int[0, 0] : result;
    }
}