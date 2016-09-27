
using System;
class Operator
{
    public static void Main()
    {
        const double R = 2; // Радиус
            double x, y; //Координаты точки
            bool g; //Значение функции
            char rep; //Признак повторного ввода
            string str; //строка для приема данных
            Console.Clear(); //Очищение строки
            Console.Write("Введите X: ");
            str = Console.ReadLine();
            x = double.Parse(str);
            Console.Write("Введите Y: ");
            str = Console.ReadLine();
            y = double.Parse(str);

            if (x * x + y * y <= R * R) //в круге
                if (x >= 0) //и справа от оси Y
                    if (y <= x) //и ниже прямой y=x
                        g = true; //в фигуре
                    else //и выше прямой y=x
                        g = false; //не в фигуре
                else //и слева от оси Y
                    g = false; //вне фигуры
            else //вне круга
                g = false; //вне фигуры

        str = string.Format("G({0:f3},{1:f3}) = {2}", x, y, g);
        Console.Write("G= ", str);
        Console.WriteLine(str);
    }
}

