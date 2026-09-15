using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Password_Checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========== Password Checker Program ==========");
            Console.WriteLine();
            string password_again = "";
            string password = "";
            bool flag = true;
            while (flag)
            {
                ShowMenu();
                Console.Write("Please choose a number : ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Please enter your new password : ");
                        password = Console.ReadLine();
                        Console.WriteLine("Enter your password again: ");
                        password_again = Console.ReadLine();
                        if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(password_again))
                        {
                            Console.WriteLine("The password was not created!");
                        }
                        else
                        {
                            if (password.Length < 6 || password_again.Length < 6)
                            {
                                Console.WriteLine("Your password shoud have 6 or more characters!");
                            }
                            else
                            {
                                if (password.Equals(password_again))
                                {
                                    Console.WriteLine("Password created Successfully!");
                                }
                                else
                                {
                                    Console.WriteLine("Password does not match!");
                                }
                            }
                            
                        }
                        break;
                    case 2:
                        if (string.IsNullOrEmpty(password))
                        {
                            Console.WriteLine("You did not create your password!");
                        }
                        else
                        {
                            Console.Write("Please enter your password to enter : ");
                            string check_password = Console.ReadLine();
                            if (password.Equals(check_password))
                            {
                                Console.WriteLine("Loged In!");
                            }
                            else
                            {
                                Console.WriteLine("Incorrect Password!");
                            }
                        }
                        break;
                    case 3:
                        Console.WriteLine("Exited!");
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid choice!");
                        break;
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }

            Console.ReadKey();
        }
        static void ShowMenu()
        {
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("1. Create a password");
            Console.WriteLine("2. Login");
            Console.WriteLine("3. Quit");
            Console.WriteLine("-----------------------------------------------");

        }
    }
}
