using System;

namespace Practical_4_8_3_ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Угадай число");
            Console.WriteLine(" Введите верхнюю границу диапазона для поиска");
            int n = int.Parse(Console.ReadLine());
            Random r = new Random();
            int goal = r.Next(n);
            string str;
            while (true)
            {
                Console.WriteLine(" Введите число,если устали нажмите Enter");
                str = Console.ReadLine();
                if (str == string.Empty)
                {
                    Console.WriteLine(" Вы сдались. Это число {0}", goal);
                    break;
                }
                if (int.Parse(str) == goal)
                {
                    Console.WriteLine(" Вы угадали ", goal);
                    break;
                }
                else if (int.Parse(str) > goal)
                {
                    Console.WriteLine(" Ваше число больше");
                }

                else
                {
                    Console.WriteLine(" Ваше число меньше");
                }



            }
            Console.ReadKey();


        }
    }
}
