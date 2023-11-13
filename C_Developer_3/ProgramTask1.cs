using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class ProgramTask1
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int userValue = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (userValue % 2 == 0)
            {
                Console.WriteLine($"Число {userValue} является четным");
            }
            else
            {
                Console.WriteLine($"Число {userValue} является нечетным");
            }
            Console.ReadKey();
        }
    }
}
