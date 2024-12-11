using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Первая буква: ");
            char letter = Char.ToLower(Console.ReadKey().KeyChar);
            switch (letter)
            {
                case 'ф':
                    Console.WriteLine("физика");
                    break;
                case 'м':
                    Console.WriteLine("математика");
                    break;
                case 'и':
                    Console.WriteLine("история");
                    break;
                case 'г':
                    Console.WriteLine("география");
                    break;
                case 'б':
                    Console.WriteLine("биология");
                    break;
                default:
                    Console.WriteLine("ошибка");
                    break;
            }
            Console.Read();
        }   
        
    }
}
