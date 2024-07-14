using System;

namespace tassk_three
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*myFav();*/

            /*Console.Write("Input three numbers separated by comma: ");
            string input = Console.ReadLine();
            threeNmbersSum(input);
            oddNumbers();*/

            printPattren();
            printPattren1();
        }

        static void correctTheError()
        {

            int[] ARR = { 1, 7, 9, 45 };
            string[] arr2 = { "Str", "alex", "moh" };
            string[] arr3 = { "'the'", "'fox'", "'over'", "lazy", "'dog'" };

        }
        /*What the index of "Banana","Tomato"?
        String [ ]  fruits=["Tomato","Banana","Watermelon"]
        */
        static int IndexOf(string[] arr, string value)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }
        /*        Create an multiple arrays that represents your:
        Favorite Food(5 item)
        Favorite Sport(3 item)
        Favorite Movie(4 item)
        Then, print each array using foreach, and Loop Through an Array*/
        static void myFav()
        {
            string[] food = { "Pizza", "Sushi", "Burger", "Pasta", "Ice Cream" };
            string[] sports = { "Football", "Basketball", "Tennis" };
            string[] movies = { "The Shawshank Redemption", "Inception", "The Dark Knight", "Pulp Fiction" };
            loopArray(food);
            loopArray(sports);
            loopArray(movies);


        }
        static void loopArray(string[] arr)
        {
            foreach (string s in arr)
            {
                Console.WriteLine(s);
            }
        }
        /*Write a program in C# to calculate the sum of three numbers with getting input in one line separated by a comma
        Expected Output:
        Input three numbers separated by comma: 5,10,15
        The sum of three numbers: 30.
        */
        static void threeNmbersSum(string nums)
        {
            string[] numbers = nums.Split(',');
            int[] intNumbers = Array.ConvertAll(numbers, number => int.Parse(number.Trim()));
            int sum = 0;
            foreach (int number in intNumbers)
            {
                sum += number;
            }
            Console.WriteLine(sum);
        }
        static void oddNumbers()
        {
            int sumOfOddNUmbers = 0;
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                    sumOfOddNUmbers += i;
                }
            }
            Console.WriteLine(sumOfOddNUmbers);
        }
        /*
        Write a program in C## to display the pattern like right angle triangle using an asterisk. Go to the editor
        The pattern like:
           *
          **
         ***
        */
        static void printPattren()
        {
            
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3 - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void printPattren1()
        {
            int rows = 4; 
            int currentNumber = 1; 

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write("  ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write($"{currentNumber,2} ");
                    currentNumber++;
                }
                Console.WriteLine();
            }
        }
    }
}


