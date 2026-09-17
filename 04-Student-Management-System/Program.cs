using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _04_Student_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int students;
                Dictionary<string, int> myDict = new Dictionary<string, int>();
                List<double> grades = new List<double>();

                Console.Write("How many students do you have: ");
                int studentsCount = Convert.ToInt16(Console.ReadLine());
                string[] names = new string[studentsCount];

                for (int i = 0; i < studentsCount; i++)
                {
                    Console.WriteLine("Student full name : ");
                    string studentName = Console.ReadLine();

                    Console.WriteLine("Student Grade : ");
                    int studentGrade = Convert.ToInt16(Console.ReadLine());

                    names[i] = studentName;

                    grades.Add(studentGrade);

                    myDict.Add(studentName, studentGrade);
                }


                Console.WriteLine("Acceptence Status : ");
                foreach (var item in myDict)
                {
                    if (item.Value < 10)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Thread.Sleep(400);
                        Console.WriteLine($"{item.Key} is Failed!");
                        Console.ResetColor();

                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Thread.Sleep(400);
                        Console.WriteLine($"{item.Key} is Passed!");
                        Console.ResetColor();

                    }
                }
            }
            catch(FormatException)
            {
                Console.WriteLine("Please enter just number!");
            }

            Console.ReadKey();
        }
        static double AverageCalculator(List<int> numbers)
        {
            double sum = 0;
            for (int i = 0;i < numbers.Count;i++)
            {
                sum += numbers[i];
            }
            return sum / numbers.Count;

        }
        static int MaxGrade(List<int> numbers)
        {
            return numbers.Max();
        }
    }
}
