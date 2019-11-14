using System;

namespace _01._Centuries_to_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            //int centures = int.Parse(Console.ReadLine());

            //int years = centures * 100;
            //int days = (int)(years * 365.2422);
            //int hours = days * 24;
            //int minutes = hours * 60;

            //Console.WriteLine($"{centures} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");

            sbyte centures = sbyte.Parse(Console.ReadLine());

            ushort years = (ushort)(centures * 100);
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            int minutes = hours * 60;

            Console.WriteLine($"{centures} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");


            //int num = int.Parse(Console.ReadLine());

            //int a = num++;
            //int b = ++num;

            //int result = a + b;

            //Console.WriteLine(result);
        }
    }
}