using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PyankovaVV.Sprint1.Task3.V11.Lib;

namespace Tyuiu.PyankovaVV.Sprint1.Task3.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Пьянкова В. В.| АСОиУб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнила: Пьянкова Виктория Вячеславовна | АСОиУб-23-2                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет площадь треугольника,             *");
            Console.WriteLine("* если известны координаты его углов.                                     *");
            Console.WriteLine("* 0.5 * ((x1 - x3) * (y2 - y3) - (x2 - x3) * (y1 - y3)                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите координаты углов (числа разделяйте пробелом):");

            Console.Write("x1 -> ");
            double x1 = double.Parse(Console.ReadLine());

            Console.Write("y1 -> ");
            double y1 = double.Parse(Console.ReadLine());

            Console.Write("x2 -> ");
            double x2 = double.Parse(Console.ReadLine());

            Console.Write("y2 -> ");
            double y2 = double.Parse(Console.ReadLine());
            
            Console.Write("x3 -> ");
            double x3 = double.Parse(Console.ReadLine());

            Console.Write("y3 -> ");
            double y3 = double.Parse(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double area = ds.TriangleArea(x1, x2, x3, y1, y2, y3);
            Console.WriteLine($"Площадь треугольника: {area} кв.см");

            Console.ReadLine();
        }
    }
}
