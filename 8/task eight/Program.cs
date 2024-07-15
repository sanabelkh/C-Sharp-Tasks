using System.Linq;
using System.Text.RegularExpressions;

namespace task_eight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(sumOfCubes([1, 5, 9]));
            Console.WriteLine(secondLargest([25, 143, 89, 13, 105]));
            Console.WriteLine(isRepdigit("00009"));
            Console.WriteLine(sevenBoom([1, 2, 3, 4, 5, 6]));
            Console.WriteLine();
            string[] arr = removeDups(["John", "Taylor", "John"]).ToArray();
            foreach (string s in arr) Console.WriteLine(s);



        }
        static int add(int x, int y)
        {
            return x + y;
        }
        static string removeLeadingTrailing(string str)
        {
            str = str.TrimStart('0');
            if (str.Contains('.'))
            {
                str = str.TrimEnd('0');
                if (str.EndsWith("."))
                {
                    str = str.TrimEnd('.');
                }
            }
            return str;
        }
        static int secondLargest(int[] arr)
        {
            if (arr.Length < 2)
            {
                Console.WriteLine("Array must contain at least two elements");
                return -1;
            }

            int max = int.MinValue;
            int secondMax = int.MinValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    secondMax = max;
                    max = arr[i];
                }
                else if (arr[i] > secondMax && arr[i] != max)
                {
                    secondMax = arr[i];
                }
            }
            return secondMax;
        }
        static bool isRepdigit(string num)
        {
            int count = num.Count(c => c == num[0]);
            if (count == num.Length)
            {
                return true;
            }
            return false;
        }

        static string reverseString(string str)
        {
            string[] arr = str.Split(' ');
            string newStr = "";

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                newStr += arr[i] + " ";
            }

            return newStr;
        }
        static string sevenBoom(int[] arr)
        {
            foreach (int i in arr)
            {
                if (i == 7)
                {
                    return "boom";
                }
            }
            return "there is no 7 in the array";
        }
        static string insertWhitespace(string str)
        {
            string[] words = Regex.Split(str, @"(?=[A-Z])");
            return string.Join(" ", words).TrimStart(' ');
        }
        static int countTrue(bool[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i])
                {
                    count++;
                }
            }
            return count;
        }
        static string capToFront(string str)
        {
            string lower = "";
            string upper = "";
            foreach(char c in str)
            {
                if (char.IsUpper(c))
                {
                    upper += c;
                }
                else
                {
                    lower+= c;
                }

            }
            return upper+lower;
        }
        static bool matchLastItem(string[] arr)
        {
            string str = "";
            for (int i = 0; i < arr.Length - 1; i++)
            {
                str += arr[i];

            }
            if (str == arr[arr.Length - 1])
            {
                return true;
            }
            return false;
        }
        static List<string> removeDups(string[] strs)
        {
            List<string> result = new List<string>();

            foreach (string str in strs)
            {
                if (!result.Contains(str))
                {
                    result.Add(str);
                }
            }

            return result;
        }
        static string convertTime(string time)
        {
            DateTime parsedTime;
            if (!DateTime.TryParse(time, out parsedTime))
            {
                return"Invalid time format.";
            }
            return parsedTime.ToString("HH:mm");
        }
        static string removeLastVowel(string str)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            string[] words = str.Split(' ');
            string temp = "";

            for (int j = 0; j < words.Length; j++)
            {
                string word = words[j];
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    if (vowels.Contains(word[i]))
                    {
                        words[j] = word.Remove(i, 1);
                        temp += words[j] + " ";
                        break; 
                    }
                }
            }

            return temp;
        }
        static int sumOfCubes(int[] numbers)
        {
            int sum = 0;

            foreach (int num in numbers)
            {
                sum += num * num * num; 
            }

            return sum;
        }

    }
}
