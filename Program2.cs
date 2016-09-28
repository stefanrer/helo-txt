using System;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Введите число: ");
        var x = int.Parse(Console.ReadLine());
        //double x_4 = x % 4;
        if ((x & 3) == 0)
            Console.WriteLine(x / 4);
        else
            Console.WriteLine(x + 4);
        //Console.ReadLine();
    }
}
