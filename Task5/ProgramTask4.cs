using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class ProgramTask4
    {
        static void Main(string[] args)
        {
            int userCount;
            int userInput;
            int minValue = int.MaxValue;

            Console.Write("Введите длину последовательности: ");
            if (int.TryParse(Console.ReadLine(), out userCount))
            {
                Console.WriteLine("Какие цифры сравниваем?");
                for (int i = 0; i < userCount; i++)
                {                    
                    if (int.TryParse(Console.ReadLine(), out userInput))
                    {                        
                        if(userInput < minValue) minValue = userInput;
                    }
                    else
                    {                        
                        Console.WriteLine("Это не цифра!((");
                        i--;
                    }
                }
                Console.WriteLine();
                Console.WriteLine($"Наименьший элемент в последовательности {minValue}");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Это не цифра!((");
            }
            Console.ReadKey();
        }
    }
}
