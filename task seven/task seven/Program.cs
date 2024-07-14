
namespace task_seven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            getDays(new DateTime(2019, 6, 14), new DateTime(2019, 6, 20));
            List<string> list = numInStr(["1a", "a", "2b", "b"]);
            foreach (string str in list)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine(IsPandigital(98140723568910));
        }

        static void getDays(DateTime d1, DateTime d2)
        {
            TimeSpan difference;
            if (d1 > d2)
            {
                difference = d1 - d2;
            }
            else 
            {
                difference = d2 - d1; 
            }
            Console.WriteLine(difference.Days);
        }
        
        static List<string> numInStr(string[] strs)
        {
            List<string> result = new List<string>();
            foreach (string str in strs)
            {
                foreach (char c in str)
                {
                    if (char.IsDigit(c))
                    {
                        result.Add(str);
                    }
                }
            }
            return result;
        }
        static string reverseOdd(string str)
        {
            string[] arr = str.Split(' ');

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length % 2 != 0)
                {
                    arr[i] = new string(arr[i].Reverse().ToArray());
                }
            }

            return string.Join(" ", arr);
        }
        static bool IsPandigital(long num)
        {
            string str = num.ToString();
            for (int i = 0; i < 10; i++)
            {
                if (!str.Contains(i.ToString()))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
