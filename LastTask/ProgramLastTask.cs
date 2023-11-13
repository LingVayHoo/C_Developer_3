using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastTask
{
    internal class ProgramLastTask
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int userCount;
            int userInput;
            int targetNumber;

            Console.Write("Играем в диапазоне от 0 до: ");

            if (int.TryParse(Console.ReadLine(), out userCount))
            {
                targetNumber = rnd.Next(0, userCount + 1);
                while (true)
                {
                    Console.WriteLine("Какое число загадано? ");
                    if (int.TryParse(Console.ReadLine(), out userInput))
                    {                        
                        if (userInput > targetNumber) Console.WriteLine("Нет! Это число больше загаданного!");
                        else if (userInput < targetNumber) Console.WriteLine("Нет! Это число меньше загаданного!");
                        else
                        {
                            Console.WriteLine("Вы угадали!");
                            break;
                        }
                    }
                    else if (Console.ReadLine() == "")
                    {
                        Console.WriteLine($"Загаданное число {targetNumber}!");
                        Console.WriteLine("Выход из игры!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Неверный ввод!");
                    }
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Неверный ввод!");
            }
            Console.ReadKey();
        }
    }
}
