using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string test = "test";

            double meal_cost = 100;
            int tip_percent = 15;
            int tax_percent = 8;
            var s = (meal_cost + tip_percent + tax_percent);
            Console.Write("total："+s);

        }
    }
}
