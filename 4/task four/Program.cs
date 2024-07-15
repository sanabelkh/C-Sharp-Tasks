using System;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace task_four
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(numOfWords("is prime. dsfoj sdihu dsjfis"));

            Console.WriteLine(leapYear(2024));
            power(5, 2);
            string username= Console.ReadLine();
            string password = Console.ReadLine();
            Console.WriteLine(login(username, password));
            CubeOfNumber(7);
            int[] years = { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 };

            List<int> filteredYears = GetYears(years);
            foreach (int year in filteredYears)
            {
                Console.WriteLine(year);
            }
            Console.WriteLine(numOflegs(2,2,2));

            
        }

        static int[] InputTenNumbers()
        {
            int[] nums = new int[10];
            Console.WriteLine("Enter 10 numbers:");

            for (int i = 0; i < 10; i++)
            {
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }

            return nums;
        }

        static string SumOfTenNumbers()
        {
            int[] numbers = InputTenNumbers();
            int sum = 0;
            double avg = 0;

            foreach (int num in numbers)
            {
                sum += num;
            }

            avg = (double)sum / 10;

            return $"The sum is {sum}\nThe average is {avg}";
        }

        static void CubeOfNumber(int num)
        {
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"{i} cubed is {Math.Pow(i, 3)}");
            }
        }

        static List<int> GetYears(int[] years)
        {
            List<int> numberList = new List<int>();
            foreach (int year in years)
            {
                if (year >= 1950)
                {
                    numberList.Add(year);
                }
            }
            return numberList;
        }
        static int ageInYears(int year)
        {
            return year * 365;
        }
        static int numOflegs(int pigs, int cows, int chickens)
        {
            if (chickens < 0 || cows < 0 || pigs < 0)
            {
                Console.WriteLine("wrong input");
                return 0;
            }
            return pigs * 4 + cows * 4 + chickens * 2;
        }
        static bool login(string username, string password)
        {
            string[] names = { "Alice", "Bob", "Charlie", "David", "Eve" };
            string[] passwords = { "pass123", "secret456", "letmein", "qwerty", "password" };

            for (int i = 0; i < names.Length; i++)
            {
                if (username == names[i] && password == passwords[i])
                {
                    return true;
                }
                
            }
            return false;
        }
        static void power(int num, int pow)
        {
            Console.WriteLine(Math.Pow(num, pow));
        }
        static bool leapYear(int year)
        {
            if (year % 4 == 0)
            {
                if (year % 100 == 0 && year % 400 == 0)
                {
                    return true;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
        static bool isItPrime(int num)
        {
            if (num <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static int numOfWords(string sentence)
        {
            string[] arr= sentence.Split(' ');

            return arr.Length;

        }

    }
}
