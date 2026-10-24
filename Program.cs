using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

namespace Student_Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> studentGrades = new List<int>();
            while (true)
            {
                Console.Write("How many student grades would you like to enter: ");
                if (int.TryParse(Console.ReadLine(), out int numberOfStudents))
                {
                    bool result = false;
                    while (!result)
                    {
                        for (int i = 0; i < numberOfStudents; i++)
                        {
                            Console.Write($"Enter the grade number {i + 1}: ");
                            if (int.TryParse(Console.ReadLine(), out int grade))
                            {
                                if (grade >= 0 && grade <= 100)
                                {
                                    Console.WriteLine($"Grade {i + 1} is: {grade}");
                                    studentGrades.Add(grade);
                                    result = true;
                                }
                                else
                                {
                                    Console.WriteLine("Please Enter a valid grade (from 0 to 100)!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please enter a valid number!");
                            }

                        }
                    }



                    int calcTotal = 0;
                    foreach (int grade in studentGrades)
                    {
                        int total = calcTotal += grade;
                    }

                    int normalTotal = CalculateTotal(studentGrades);
                    int bonusTotal = CalculateTotal(studentGrades, 5);

                    Console.WriteLine($"The normal total is: {normalTotal}");
                    Console.WriteLine($"The bonus total is: {bonusTotal}");
                    break;
                }

                else
                {
                    Console.WriteLine("Please enter a valid number only.");
                }
            }

        }
        static int CalculateTotal(List<int> studentGrades)
        {
            int calcTotal = 0;
            foreach (int grade in studentGrades)
            {
                calcTotal += grade;
            }
            return calcTotal;
        }
        static int CalculateTotal(List<int>studentGrades, int bonus)
        {
            int calcTotal = 0;
            foreach(int grade in studentGrades)
            {
                calcTotal += grade;
            }
            calcTotal += bonus;
            return calcTotal;
        }
    }
}
