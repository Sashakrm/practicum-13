using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Первая буква: ");
            char letter = Char.ToLower(Console.ReadKey().KeyChar);
            switch (letter)
            {
                case 'к':
                    Circle();
                    break;
                case 'п':
                    Square();
                    break;
                case 'т':
                    Triangle();
                    break;
            }
        }
        static int Input(string message)
        {
            Console.WriteLine(message);
            return int.Parse(Console.ReadLine());
        }
        static void Circle()
        {
            int r = Input("Радиус круга: ");
            double perimetr_1 = 2 * 3.14 * r;
            double s_1 = 3.14 * (r * r);
            Console.WriteLine($"Периметр круга: {perimetr_1}");
            Console.WriteLine($"Площадь круга: {s_1}");
            Console.Read();
        }
        static void Square()
        {
            var side_1 = Input("Первая сторона прямоугольника: ");
            var side_2 = Input("Вторая сторона прямоугольника: ");
            double perimetr_2 = side_1 * 2 + side_2 * 2;
            double s_2 = side_1 * side_2;
            Console.WriteLine($"Периметр прямоугольника: {perimetr_2}");
            Console.WriteLine($"Площадь прямоугольника: {s_2}");
            Console.Read();
        }
        static void Triangle()
        {
            int h = Input("Высота треугольника: ");
            int footing = Input("Основание треугольника: ");
            int side1 = Input("Вторая сторона:");
            int side2 = Input("Третья сторона: ");
            double perimetr_3 = footing + side1 + side2;
            double s_3 = (footing * h) / 2;
            Console.WriteLine($"Периметр треугольника: {perimetr_3}");
            Console.WriteLine($"Площадь треугольника: {s_3}");
            Console.Read();
        }
    }
}
