using System;

namespace _05._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            // 356
            //356 % 10 ->  6!
            //356 / 10 -> 35
            //35 % 10  ->  5!
            //35 / 10  -> 3
            //3 % 10   ->  3!
            //3 / 10   -> 0

            for (int i = 1; i <= n; i++)
            {
                int number = i;
                int sum = 0;
                while (number != 0)
                {
                    int currentNumber = number % 10;
                    number /= 10;
                    sum += currentNumber;
                }
                bool isSpecial = false;

                if (sum == 5 || sum == 7 || sum == 11)
                {
                    isSpecial = true;
                }
                Console.WriteLine($"{i} -> {isSpecial}");
            }
        }
    }
}