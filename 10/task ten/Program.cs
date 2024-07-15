using System.IO;

namespace task_ten
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string str = "";
            string myInfoPath = @"C:\Users\hmaje\Desktop\csharp tasks\myInfo.txt";


                if (File.Exists(myInfoPath))
                {
                    string[] lines = File.ReadAllLines(myInfoPath);
                    str = File.ReadAllText(myInfoPath);

                    foreach (string line in lines)
                    {
                        Console.WriteLine(line);
                    }
                }
                else
                {
                    Console.WriteLine("File does not exist at the specified path.");
                    return;
                }

                int charCount = str.Count(c => !char.IsWhiteSpace(c));
                Console.WriteLine($"Number of characters (excluding spaces): {charCount}");

                string[] words = str.Split(new char[] { ' ','\n' }, StringSplitOptions.RemoveEmptyEntries);
                Console.WriteLine($"Number of words: {words.Length}");
            


            int[] myArray = { 10, 20, 30, 40, 50 };

            findTheNumberAtIndex(myArray, 2); 

            findTheNumberAtIndex(myArray, 10);
        }
        public static void findTheNumberAtIndex(int[] arr, int number)
        {
            try
            {
                if (number >= 0 && number < arr.Length)
                {
                    Console.WriteLine($"Number at index {number} is: {arr[number]}");
                }
                else
                {
                    throw new IndexOutOfRangeException("Index is out of range.");
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}