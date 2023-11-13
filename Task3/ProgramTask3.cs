using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class ProgramTask3
    {
        static void Main(string[] args)
        {
            int userInput;
            int n = 1;
            bool failed = false;

            Console.WriteLine("Привет! Я мастер спорта по проверке простых чисел!");
            Console.WriteLine();
            Console.Write("Какое число необходимо проверить? ");

            if (int.TryParse(Console.ReadLine(), out userInput) && userInput > 0)
            {
                while (n < userInput)
                {
                    if (userInput % n == 0)
                    {
                        failed = true;
                        break;
                    }
                    n++;
                }

                if (failed)                
                    Console.WriteLine($"Число {userInput} не является простым");                
                else                
                    Console.WriteLine($"Число {userInput} является простым");                
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Мне нужно было натуральное число!");
            }
            Console.ReadKey();
        }
        
    }
}
