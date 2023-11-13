using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class ProgramTask2
    {
        static void Main(string[] args)
        {
            bool guards = false;
            int cardCount;
            int cardSumValue = 0;            
            Random random = new Random();
            int dealersSumValue = random.Next(1, 22);

            Console.WriteLine("Добро пожаловать в Blackjack");
            Console.WriteLine();
            Console.WriteLine("В игре участвуют карты с 2 по 10, а также");
            Console.WriteLine();
            Console.WriteLine("J - Валет");
            Console.WriteLine("Q - Дама");
            Console.WriteLine("K - Король");
            Console.WriteLine("T - Туз"); // Мне кажется, что здесь должно быть A))
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Сколько карт у тебя в руках? ");

            if (int.TryParse(Console.ReadLine(), out cardCount))
            {
                if (cardCount > 0)
                {
                    for (int i = 0; i < cardCount; i++) 
                    {
                        if (guards) break;
                        string ending;
                        string userInput;
                        int cardValue;
                        if (i == 3) ending = "ей";
                        else ending = "ой";
                        Console.Write($"Введи номинал {i}-{ending} карты: ");

                        userInput = Console.ReadLine();
                        if (int.TryParse(userInput, out cardValue) && cardValue > 1 && cardValue <= 10)
                        {
                            cardSumValue += cardValue;
                        }
                        else
                        {
                            switch (userInput)
                            {
                                case "J":
                                case "Q":
                                case "K":
                                case "T":
                                    cardSumValue += 10;
                                    break;
                                default:
                                    Console.WriteLine();
                                    Console.WriteLine("Уверен? Охрана, у нас шулер!!!");  
                                    guards = true;
                                    break;
                            }
                        }
                    }
                    if (!guards)
                    {
                        if (cardSumValue > dealersSumValue)
                            Console.WriteLine($"Сумма твоих карт - {cardSumValue}! У меня {dealersSumValue}! Перебор!");
                        else if (cardSumValue > 0 && cardSumValue <= dealersSumValue)
                            Console.WriteLine($"Сумма твоих карт - {cardSumValue}! У меня {dealersSumValue}! Неплохо!");
                    }
                    
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Это как? Охрана, выведите его, он пьян!");
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Это как? Охрана, выведите его, он пьян!");
            }
            Console.ReadKey();           
        }
    }
}
