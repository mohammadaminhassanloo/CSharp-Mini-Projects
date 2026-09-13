using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Simple_Math_Calculate_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========== Simple Calculator Game ==========");
            Console.WriteLine();
            Console.WriteLine();
            StartGame();
            bool flag = true;
            double userInput = 0;
            double result = 0;
            int score = 0;
            while (flag)
            {
                Random random = new Random();
                Random random_2 = new Random();
                double first_random = random.Next(1, 101);
                double second_random = random.Next(1, 10);
                List<char> char_list = new List<char>();
                char_list.Add('+');
                char_list.Add('-');
                char_list.Add('/');
                char_list.Add('*');
                int random_index = random_2.Next(char_list.Count);
                char random_char = char_list[random_index];
                
                switch (random_char)
                {
                    case '+':
                        Console.Write($"{first_random} + {second_random} = ");
                        userInput = Convert.ToDouble(Console.ReadLine());
                        result = first_random + second_random;
                        if (userInput == result)
                        {
                            Console.WriteLine("Good Job");
                            score += 5;
                        }
                        else
                        {
                            Console.WriteLine("You failed!");
                        }
                        break;
                    case '-':
                        Console.Write($"{first_random} - {second_random} = ");
                        userInput = Convert.ToDouble(Console.ReadLine());
                        result = first_random - second_random;
                        if (userInput == result)
                        {
                            Console.WriteLine("Good Job");
                            score += 5;
                        }
                        else
                        {
                            Console.WriteLine("You failed!");
                        }
                        break;

                    case '/':
                        Console.Write($"{first_random} / {second_random} = ");
                        userInput = Convert.ToDouble(Console.ReadLine());
                        result = Math.Round(first_random / second_random, 1);
                        if (Math.Round(userInput, 1) == Math.Round(result, 1))
                        {
                            Console.WriteLine("Good Job");
                            score += 5;

                        }
                        else
                        {
                            Console.WriteLine("You failed!");
                        }
                        break;
                    case '*':
                        Console.Write($"{first_random} * {second_random} = ");
                        userInput = Convert.ToDouble(Console.ReadLine());
                        result = Math.Round(first_random * second_random, 2);
                        if (userInput == result)
                        {
                            Console.WriteLine("Good Job");
                            score += 5;

                        }
                        else
                        {
                            Console.WriteLine("You failed!");
                        }
                        break;
                }
                Console.WriteLine("Do you want to play again? (Y,N) : ");
                string playagain = Console.ReadLine().ToUpper();
                if (playagain == "Y")
                {
                    flag = true;
                }
                else if (playagain == "N")
                {
                    Console.WriteLine("You did well!");
                    Console.WriteLine($"You gained {score} scores!");
                    flag = false;
                }
                
                }

        }
        static void StartGame()
        {
            do
            {
                Console.WriteLine("Please press enter to start the game!");
            }
            while (Console.ReadKey(intercept: true).Key != ConsoleKey.Enter);
            {
                Console.WriteLine("Game Started!");
            }
        }
    }
}
