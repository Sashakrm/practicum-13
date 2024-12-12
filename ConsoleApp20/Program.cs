using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Первая буква: ");
            char letter = Char.ToLower(Console.ReadKey().KeyChar);
            switch (letter)
            {
                case 'а':
                    Console.WriteLine("Максимальная развитая скорость автомобиля: 1228 км/ч");
                    break;
                case 'в':
                    Console.WriteLine("Максимальная развитая скорость на велосипеде: 210 км/ч");
                    break;
                case 'м':
                    Console.WriteLine("Максимальная развитая скорость на мотоцикле: 605 км/ч");
                    break;
                case 'с':
                    Console.WriteLine("Максимальная развитая скорость на самолете: 6125 км/ч");
                    break;
                case 'п':
                    Console.WriteLine("Максимальная развитая скорость на поезде: 10430 км/ч");
                    break;
                default:
                    Console.WriteLine("ошибка");
                    break;
            }
            Console.Read();
        }
    }
}
