using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            var x = double.Parse(Console.ReadLine());
            double x_2 = x % 2;
            if (x_2 == 0)
                Console.WriteLine(x / 2);
            else
                Console.WriteLine(x = (x + 1) / 2);
            Console.ReadLine();

        }
    }
}

