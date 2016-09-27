using System;
class Operator
{
    public static void Main()
    {
        double x, y, g;
        string str;       // Рабочая строка для ввода и вывода данных 
        Console.Clear(); //Очищение строки
        Console.Write("Введите X: ");
        str = Console.ReadLine();
        x = double.Parse(str);
        Console.Write("Введите Y: ");
        str = Console.ReadLine();
        y = double.Parse(str);

        if (x < y && x > 0)
            g = x + Math.Sin(y);
        else if (x > y && x < 0)
            g = y - Math.Cos(x);
        else g = 0.5 * x * y;
        str = g.ToString();
        Console.WriteLine("g=" + str);
        Console.ReadLine();
    } //Конец определения метода
} //Конец объявления класса

