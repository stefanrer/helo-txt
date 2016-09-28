using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число от 1 до 10");
             var x = double.Parse(Console.ReadLine());
             if (x > 3) Console.WriteLine("Зачет");
             else Console.WriteLine("Незачет");
            Console.ReadLine();


            

            
        }
    }
}
