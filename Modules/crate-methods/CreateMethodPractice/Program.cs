using System;

namespace CreateMethods
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*Program executor = new Program();
             Console.WriteLine("Generating random numbers");
             executor.DisplayRandomNumbers(); */

            int[] times = { 800, 1200, 1600, 2000 };
            int diff = 0;

            Console.WriteLine("Enter current GMT");
            int currentGMT = Convert.ToInt32(Console.ReadLine());

            DisplayTimes(times);

            Console.WriteLine("Enter new GMT");
            int newGMT = Convert.ToInt32(Console.ReadLine());

            if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
            {
                Console.WriteLine("Invalid GMT");
            }
            else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
            {
                diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));

                /* Adjust the times by adding the difference, keeping the value within 24 hours */
                AdjustTimes(times, diff);
            }
            else
            {
                diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));

                /* Adjust the times by adding the difference, keeping the value within 24 hours */
                AdjustTimes(times, diff);
            }

            DisplayTimes(times);

        }

        static void AdjustTimes(int[] times, int diff)
        {
            for (int i = 0; i < times.Length; i++)
            {
                times[i] = ((times[i] + diff)) % 2400;
            }
        }

        static void DisplayTimes(int[] times)
        {
            Console.WriteLine("New Medicine Schedule:");

            foreach (int val in times)
            {
                string time = val.ToString();
                int len = time.Length;

                if (len >= 3)
                {
                    time = time.Insert(len - 2, ":");
                }
                else if (len == 2)
                {
                    time = time.Insert(0, "0:");
                }
                else
                {
                    time = time.Insert(0, "0:0");
                }

                Console.Write($"{time} ");
            }

            Console.WriteLine();
        }

        void DisplayRandomNumbers()
        {
            Random randomNumber = new Random();

            for (var i = 0; i < 5; i++)
            {
                Console.WriteLine($"{randomNumber.Next(1, 100)}");
            }
            Console.WriteLine();
        }
    }
}