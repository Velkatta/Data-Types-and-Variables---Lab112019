using System;

namespace _06._Triples_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < n; k++)
                {
                    for (int g = 0; g < n; g++)
                    {
                        char letterA = (char)('a' + i);
                        char letterB = (char)('a' + k);
                        char letterC = (char)('a' + g);
                        Console.WriteLine($"{letterA}{letterB}{letterC}");
                    }
                }
            }

            //for (char i = 'a'; i < 'a' + n; i++)
            //{
            //    for (char k = 'a'; k < 'a' + n; k++)
            //    {
            //        for (char g = 'a'; g < 'a' + n; g++)
            //        {                      
            //            Console.WriteLine($"{i}{k}{g}");
            //        }
            //    }
            //}
        }
    }
}