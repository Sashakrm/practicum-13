using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = Input("Месяц по счету: ");
            string TimeYear = Month(month);
            Console.Write($"{TimeYear}");
            Console.Read();
        }
        static int Input(string mes)
        {
            Console.Write(mes);
            return int.Parse(Console.ReadLine());
        }
        static string Month(int month)
        {
            switch (month)
            {
                case 1: return "Зима";
                case 2: return "Зима";
                case 3: return "Весна";
                case 4: return "Весна";
                case 5: return "Весна";
                case 6: return "Лето";
                case 7: return "Лето";
                case 8: return "Лето";
                case 9: return "Осень";
                case 10: return "Осень";
                case 11: return "Осень";
                case 12: return "Зима";
                default: return "Ошибка";
            }
        }
    }
}
